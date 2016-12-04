
#include "stemwatch.h"

#define BASE_WIDTH 360
#define BASE_HEIGHT 360

#define HANDS_SEC_WIDTH 30
#define HANDS_SEC_HEIGHT 360
#define HANDS_MIN_WIDTH 30
#define HANDS_MIN_HEIGHT 360
#define HANDS_HOUR_WIDTH 30
#define HANDS_HOUR_HEIGHT 360
#define BTN_WIDTH 40
#define BTN_HEIGHT 40
#define ICON_HEIGHT 80
#define TEXT_BUF_SIZE 256


static struct appdata {
	Evas_Object *win;
	Evas_Object *bg;

	Evas_Object *hands_sec;
	Evas_Object *hands_min;
	Evas_Object *hands_hour;
	Evas_Object *btn;
	Evas_Object *img;

	Evas_Object *scroller;
	Evas_Object *box;
	Evas_Object *rect;
	Evas_Object *circle_scroller;
	Evas_Object *ic;


	Evas_Object *conform;
	Evas_Object *layout;
	Evas_Object *nf;
	Evas_Object *label;
	Eext_Circle_Surface *circle_surface;
	float hrm_val;

} ad  = {
	.win = 0,
	.bg = 0,

	.hands_sec =0,
	.hands_min = 0,
	.hands_hour = 0,
	.btn = 0,
	.img = 0,

	.scroller = 0,
	.box = 0,
	.rect = 0,
	.circle_scroller = 0,
	.ic = 0,

	.conform = 0,
	.layout =0,
	.nf = 0,
	.label = 0,
	.circle_surface = 0 ,
	.hrm_val = 0.0,
};

typedef enum {
	PARTS_TYPE_HANDS_SEC = 0,
	PARTS_TYPE_HANDS_MIN = 1,
	PARTS_TYPE_HANDS_HOUR = 2,
	PARTS_TYPE_BTN = 3,
	PARTS_TYPE_MAX,
} parts_type_e;


static struct main_info {
	int cur_min;
	int cur_hour;
	int cur_weekday;
} s_info = {
	.cur_min = 0,
	.cur_hour = 0,
	.cur_weekday = 0,
};


typedef struct item_get{
	Elm_Object_Item *item;
	int gen_hour;
	int gen_weekday;
}lect_info;


void alarm_test(){
	int ret;
	int DELAY = 3;
	int REMIND = 0;
    int alarm_id;
    app_control_h app_control = NULL;
    ret = app_control_create(&app_control);
    ret = app_control_set_operation(app_control, APP_CONTROL_OPERATION_DEFAULT);
    ret = app_control_set_app_id (app_control, "org.example.basicui");
    //ret = app_control_set_app_id (app_control, "org.tizen.alarmslave");
    ret = alarm_schedule_after_delay(app_control, DELAY, REMIND, &alarm_id);

}


typedef struct _sensor_info
{
	sensor_h sensor; /**< Sensor handle */
	sensor_listener_h sensor_listener;
} sensorinfo;
static sensorinfo sensor_info;


static void _new_sensor_value(sensor_h sensor, sensor_event_s *sensor_data, void
*user_data)
{
	if( sensor_data->value_count < 1 )
			return;
	char buf[PATH_MAX];

	elm_object_text_set(ad.label,"?");
	sprintf(buf, "<font_size = 8><color = #FF000000>HR-%0.1f</color></font_size>", sensor_data->values[0]);
	elm_object_text_set(ad.label, buf);
	ad.hrm_val = sensor_data->values[0];
}
static void
start_pressure_sensor()
{
	elm_object_text_set(ad.label,"...");
	sensor_error_e err = SENSOR_ERROR_NONE;
	sensor_get_default_sensor(SENSOR_HRM, &sensor_info.sensor);
	err = sensor_create_listener(sensor_info.sensor, &sensor_info.sensor_listener);
	sensor_listener_set_event_cb(sensor_info.sensor_listener, 10, _new_sensor_value, ad.label);
	sensor_listener_start(sensor_info.sensor_listener);
}


void rotate_hand(Evas_Object *hand, double degree, Evas_Coord cx, Evas_Coord cy)
{
	Evas_Map *m = NULL;

	if (hand == NULL) {
		dlog_print(DLOG_ERROR, LOG_TAG, "hand is NULL");
		return;
	}

	m = evas_map_new(4);
	evas_map_util_points_populate_from_object(m, hand);
	evas_map_util_rotate(m, degree, cx, cy);
	evas_object_map_set(hand, m);
	evas_object_map_enable_set(hand, EINA_TRUE);
	evas_map_free(m);
}
int data_get_plus_angle(int minute)
{
	int angle = 0;

	if (minute >= 0 && minute < 12) {
		angle = 0;
	} if (minute >= 12 && minute < 24) {
		angle = 6;
	} else if (minute >= 24 && minute < 36) {
		angle = 12;
	} else if (minute >= 36 && minute < 48) {
		angle = 18;
	} else if (minute >= 48 && minute < 60) {
		angle = 24;
	}

	return angle;
}
static
void set_time(int hour, int minute, int second)
{
	double degree = 0.0f;
	int day_of_week = 0;

	s_info.cur_weekday = day_of_week;

	degree = second *6;
	rotate_hand(ad.hands_sec, degree, (BASE_WIDTH / 2), (BASE_HEIGHT / 2));

	if (s_info.cur_min != minute) {
			degree = minute * 6;
			rotate_hand(ad.hands_min, degree, (BASE_WIDTH / 2), (BASE_HEIGHT / 2));
			s_info.cur_min = minute;
		}

	if (s_info.cur_hour != hour) {
			degree = (hour * 30) + data_get_plus_angle(minute);
			rotate_hand(ad.hands_hour, degree, (BASE_WIDTH / 2), (BASE_HEIGHT / 2));
			s_info.cur_hour = hour;
		}
}

void data_get_resource_path(const char *file_in, char *file_path_out, int file_path_max)
{
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(file_path_out, file_path_max, "%s%s", res_path, file_in);
		free(res_path);
	}
}
char *data_get_parts_image_path(parts_type_e type)
{
	char image_path[PATH_MAX] = { 0, };
	char *resource_image = NULL;

	switch (type) {
	case PARTS_TYPE_HANDS_SEC:
		resource_image = "images/lux_3_hands_sec.png";
		break;
	case PARTS_TYPE_HANDS_MIN:
		resource_image = "images/lux_3_hands_min.png";
		break;
	case PARTS_TYPE_HANDS_HOUR:
		resource_image = "images/lux_3_hands_hr.png";
		break;
	default:
		dlog_print(DLOG_ERROR, LOG_TAG, "type error : %d", type);
		return NULL;
	}

	data_get_resource_path(resource_image, image_path, sizeof(image_path));

	return strdup(image_path);
}

void data_get_parts_position(parts_type_e type, int *x, int *y)
{
	switch (type) {
	case PARTS_TYPE_HANDS_SEC:
		*x = (BASE_WIDTH / 2) - (HANDS_SEC_WIDTH / 2);
		*y = 0;
		break;
	case PARTS_TYPE_HANDS_MIN:
		*x = (BASE_WIDTH / 2) - (HANDS_MIN_WIDTH / 2);
		*y = 0;
		break;
	case PARTS_TYPE_HANDS_HOUR:
		*x = (BASE_WIDTH / 2) - (HANDS_HOUR_WIDTH / 2);
		*y = 0;
		break;
	default:
		dlog_print(DLOG_ERROR, LOG_TAG, "type error : %d", type);
		break;
	}

}

int data_get_parts_width_size(parts_type_e type)
{
	int parts_width = 0;

	switch (type) {
	case PARTS_TYPE_HANDS_SEC:
		parts_width = HANDS_SEC_WIDTH;
		break;
	case PARTS_TYPE_HANDS_MIN:
		parts_width = HANDS_MIN_WIDTH;
		break;
	case PARTS_TYPE_HANDS_HOUR:
		parts_width = HANDS_HOUR_WIDTH;
		break;
	default:
		dlog_print(DLOG_ERROR, LOG_TAG, "type error : %d", type);
		break;
	}

	return parts_width;
}

int data_get_parts_height_size(parts_type_e type)
{
	int parts_height = 0;

	switch (type) {
	case PARTS_TYPE_HANDS_SEC:
		parts_height = HANDS_SEC_HEIGHT;
		break;
	case PARTS_TYPE_HANDS_MIN:
		parts_height = HANDS_MIN_HEIGHT;
		break;
	case PARTS_TYPE_HANDS_HOUR:
		parts_height = HANDS_HOUR_HEIGHT;
		break;
	default:
		dlog_print(DLOG_ERROR, LOG_TAG, "type error : %d", type);
		break;
	}

	return parts_height;
}
Evas_Object *view_create_parts(Evas_Object *parent, const char *image_path, int x, int y, int w, int h)
{
	Evas_Object *parts = NULL;
	Eina_Bool ret = EINA_FALSE;

	if (parent == NULL) {
		dlog_print(DLOG_ERROR, LOG_TAG, "bg is NULL");
		return NULL;
	}

	parts = elm_image_add(parent);
	if (parts == NULL) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to add image");
		return NULL;
	}

	ret = elm_image_file_set(parts, image_path, NULL);
	if (ret != EINA_TRUE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set image");
		evas_object_del(parts);
		return NULL;
	}

	evas_object_move(parts, x, y);
	evas_object_resize(parts, w, h);
	evas_object_show(parts);

	return parts;
}
void view_set_opacity_to_parts(Evas_Object *parts)
{
	if (parts == NULL) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set opacity to parts");
		return;
	}

	evas_object_color_set(parts, 255, 255, 255, 255 * 0.3);
}
Evas_Object *view_create_layout(Evas_Object *parent, const char *file_path, const char *group_name, void *user_data)
{
	Evas_Object *layout = NULL;

	if (parent == NULL) {
		dlog_print(DLOG_ERROR, LOG_TAG, "parent is NULL.");
		return NULL;
	}

	/*
	 * Create layout by EDC(edje file)
	 */
	layout = elm_layout_add(parent);
	elm_layout_file_set(layout, file_path, group_name);

	/*
	 * Layout size setting
	 */
	evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	evas_object_show(layout);

	return layout;
}

static
Evas_Object *_create_parts(parts_type_e type)
{
	Evas_Object *parts = NULL;
	char *parts_image_path = NULL;
	int x = 0, y = 0, w = 0, h = 0;

	parts_image_path = data_get_parts_image_path(type);
	data_get_parts_position(type, &x, &y);
	w = data_get_parts_width_size(type);
	h = data_get_parts_height_size(type);

	parts = view_create_parts(ad.bg, parts_image_path, x, y, w, h);

	if (parts == NULL) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to create parts : %d", type);
	}

	free(parts_image_path);

	return parts;
}
static
void popup_block_clicked(void *data, Evas_Object *obj, void *event_info)
{
	evas_object_del(obj);
}
static
void _response_cb(void *data, Evas_Object *obj, void *event_info)
{
	Evas_Object *popup = data;
	evas_object_del(popup);
}

static
void clock_response_cb(void *data, Evas_Object *obj, void *event_info)
{
	int id = (int*)data;
}

static
void create_popup(void *data, Evas_Object *obj, void *event_info){
	 Evas_Object *popup = NULL, *btn = NULL;
		 Evas_Object *button[10];
		 Evas_Object *parent = ad.layout;
		  popup = elm_popup_add(parent);
		  elm_popup_align_set(popup, ELM_NOTIFY_ALIGN_FILL, 0.0);
		  evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		  elm_object_part_text_set(popup, "title,text", "Set Time");
		  elm_popup_orient_set(popup, ELM_POPUP_ORIENT_CENTER);

		  char *index[10] = {"9:00","10:00","11:00","12:00","13:00","14:00","15:00","16:00","17:00","18:00"};
		  for(int i=0;i<10;i++)
		  {
			  button[i] = elm_button_add(popup);
			  evas_object_size_hint_weight_set(button[i], EVAS_HINT_FILL, EVAS_HINT_FILL);
			  evas_object_size_hint_align_set(button[i],EVAS_HINT_FILL, EVAS_HINT_FILL);
			  elm_object_text_set(button[i],index[i]);
			  elm_object_part_content_set(popup, "elm.swallow.content", button[i]);
			  evas_object_smart_callback_add(button[i], "clicked", clock_response_cb, i);
		 }


		   btn = elm_button_add(popup);
		   elm_object_style_set(btn, "popup");
		   evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		   elm_object_text_set(btn, "OK");
		   elm_object_part_content_set(popup, "button2", btn);
		   evas_object_smart_callback_add(btn, "clicked", _response_cb, popup);

		   btn = elm_button_add(popup);
		   elm_object_style_set(btn, "popup");
		   evas_object_size_hint_weight_set(btn, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		   elm_object_text_set(btn, "Cancel");
		   elm_object_part_content_set(popup, "button1", btn);
		   evas_object_smart_callback_add(btn, "clicked", _response_cb, popup);



		   // Register the EFL extension callback for the Back key event
		   eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK, eext_popup_back_cb, NULL);
		   evas_object_smart_callback_add(popup,"block,clicked",popup_block_clicked,parent);
		   evas_object_show(popup);



}

static void
create_base_gui(int width, int height)
{
	int ret;
	watch_time_h watch_time = NULL;
	Eina_Bool BgT = EINA_FALSE;
	char bg_path[PATH_MAX] = { 0, };

	/* Window */
	ret = watch_app_get_elm_win(&ad.win);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "failed to get window. err = %d", ret);
		return;
	}
	elm_win_autodel_set(ad.win, EINA_TRUE);
	evas_object_resize(ad.win, width, height);

	/* Conformant */
		ad.conform = elm_conformant_add(ad.win);
		evas_object_size_hint_weight_set(ad.conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		elm_win_resize_object_add(ad.win, ad.conform);
		evas_object_show(ad.conform);

		// Eext Circle Surface Creation
		ad.circle_surface = eext_circle_surface_conformant_add(ad.conform);

		/* Indicator */
		/* elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW); */

		/* Base Layout */
		ad.layout = elm_layout_add(ad.conform);
		evas_object_size_hint_weight_set(ad.layout, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
		elm_layout_theme_set(ad.layout, "layout", "application", "default");
		evas_object_show(ad.layout);

		elm_object_content_set(ad.conform, ad.layout);

		/* Naviframe */
		ad.nf = elm_naviframe_add(ad.layout);
		eext_object_event_callback_add(ad.nf, EEXT_CALLBACK_BACK, eext_naviframe_back_cb, NULL);
		eext_object_event_callback_add(ad.nf, EEXT_CALLBACK_MORE, eext_naviframe_more_cb, NULL);


	/* BG */

	ad.bg = elm_bg_add(ad.layout);

	data_get_resource_path("images/normal.png", bg_path, sizeof(bg_path));
	BgT = elm_bg_file_set(ad.bg, bg_path , NULL);
	if (BgT != EINA_TRUE) {
			dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set the background image");
			evas_object_del(ad.bg);
	}

	elm_bg_option_set(ad.bg, ELM_BG_OPTION_CENTER);

	evas_object_move(ad.bg, 0, 0);
	evas_object_resize(ad.bg, width, height);
	evas_object_show(ad.bg);
	//evas_object_hide(ad.bg);


	ret = watch_time_get_current_time(&watch_time);
	if (ret != APP_ERROR_NONE)
		dlog_print(DLOG_ERROR, LOG_TAG, "failed to get current time. err = %d", ret);


	ad.hands_sec = _create_parts(PARTS_TYPE_HANDS_SEC);
	evas_object_data_set(ad.bg, "__HANDS_SEC__", ad.hands_sec);

	ad.hands_min = _create_parts(PARTS_TYPE_HANDS_MIN);
	evas_object_data_set(ad.bg, "__HANDS_MIN__", ad.hands_min);

	ad.hands_hour = _create_parts(PARTS_TYPE_HANDS_HOUR);
	evas_object_data_set(ad.bg, "__HANDS_HOUR__", ad.hands_hour);

	/* Theme*/
	char edj_path[PATH_MAX]="";
	data_get_resource_path("edje/custom_button.edj",edj_path,(int)PATH_MAX);
	elm_theme_extension_add(NULL,edj_path);


	ad.label = elm_label_add(ad.bg);
	elm_object_text_set(ad.label, "hrm");
	evas_object_move(ad.label, 50, 230);
	evas_object_resize(ad.label, 250, 250);
	evas_object_show(ad.label);

	/* Btn */
		ad.btn=elm_button_add(ad.bg);
		elm_object_style_set(ad.btn,"customized");
		evas_object_move(ad.btn, 230, 230);
		evas_object_resize(ad.btn, 50, 50);
		evas_object_smart_callback_add(ad.btn,"clicked",create_popup,ad.nf);
		evas_object_show(ad.btn);

	evas_object_show(ad.win);
}

static bool
app_create(int width, int height, void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */

	create_base_gui(width, height);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}
static void
bg_timeout(void*data,Evas_Object*obj,void*event_info)
{
	char bg_path[PATH_MAX]={0,};
		Eina_Bool BgT = EINA_FALSE;

	data_get_resource_path("images/normal.png", bg_path, sizeof(bg_path));
	BgT = elm_bg_file_set(ad.bg, bg_path , NULL);
	if (BgT != EINA_TRUE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set the background image");
	evas_object_del(ad.bg);
	}
}
static void
app_time_tick(watch_time_h watch_time, void *data)
{
	int hour = 0;
	int min = 0;
	int sec = 0;
	int day_of_week = 0;
	char bg_path[PATH_MAX]={0,};
	Eina_Bool BgT = EINA_FALSE;

	watch_time_get_hour(watch_time, &hour);
	watch_time_get_minute(watch_time, &min);
	watch_time_get_second(watch_time, &sec);
	watch_time_get_day_of_week(watch_time, &day_of_week);

	set_time(hour, min, sec);

	sensor_listener_stop(sensor_info.sensor_listener);


	if (sec >= 20 && sec <=30){
		data_get_resource_path("images/premium_02_bg_01.png", bg_path, sizeof(bg_path));
		BgT = elm_bg_file_set(ad.bg, bg_path , NULL);
		if (BgT != EINA_TRUE)
		{
			dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set the background image");
			evas_object_del(ad.bg);
		}
		elm_object_text_set(ad.label,"NOW");
	}
if (sec%10 == 0){

	start_pressure_sensor();
	if(ad.hrm_val < 50.0){
			data_get_resource_path("images/5.png", bg_path, sizeof(bg_path));
			BgT = elm_bg_file_set(ad.bg, bg_path , NULL);
			if (BgT != EINA_TRUE)
			{
				dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set the background image");
				evas_object_del(ad.bg);
			}
		}else if(ad.hrm_val < 60.0){
			data_get_resource_path("images/4.png", bg_path, sizeof(bg_path));
			BgT = elm_bg_file_set(ad.bg, bg_path , NULL);
			if (BgT != EINA_TRUE)
			{
				dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set the background image");
				evas_object_del(ad.bg);
			}
		}else if(ad.hrm_val < 80.0){
			data_get_resource_path("images/3.png", bg_path, sizeof(bg_path));
			BgT = elm_bg_file_set(ad.bg, bg_path , NULL);
			if (BgT != EINA_TRUE)
			{
				dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set the background image");
				evas_object_del(ad.bg);
			}
		}else if (ad.hrm_val < 90.0){
			data_get_resource_path("images/2.png", bg_path, sizeof(bg_path));
			BgT = elm_bg_file_set(ad.bg, bg_path , NULL);
			if (BgT != EINA_TRUE)
			{
				dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set the background image");
				evas_object_del(ad.bg);
			}
		}else{
			data_get_resource_path("images/1.png", bg_path, sizeof(bg_path));
			BgT = elm_bg_file_set(ad.bg, bg_path , NULL);
			if (BgT != EINA_TRUE)
			{
				dlog_print(DLOG_ERROR, LOG_TAG, "Failed to set the background image");
				evas_object_del(ad.bg);
			}
		}
	}
	if(sec == 57){
		alarm_test();
	}
}

static void
app_ambient_tick(watch_time_h watch_time, void *data)
{
	/* Called at each minute while the device is in ambient mode. Update watch UI. */

}

static void
app_ambient_changed(bool ambient_mode, void *data)
{
	/* Update your watch UI to conform to the ambient mode */
}

int
main(int argc, char *argv[])
{
	int ret = 0;

	watch_app_lifecycle_callback_s event_callback = { 0, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;
	event_callback.time_tick = app_time_tick;
	event_callback.ambient_tick = app_ambient_tick;
	event_callback.ambient_changed = app_ambient_changed;

	ret = watch_app_main(argc, argv, &event_callback, NULL);
	if (ret != APP_ERROR_NONE)
		dlog_print(DLOG_ERROR, LOG_TAG, "watch_app_main() is failed. err = %d", ret);

	return ret;
}

