#ifndef __stemwatch_H__
#define __stemwatch_H__

#include <tizen.h>
#include <watch_app.h>
#include <watch_app_efl.h>
#include <Elementary.h>
#include <dlog.h>
#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <tizen.h>
#include <app_alarm.h>
#include <time.h>
#include <sensor.h>

#ifdef  LOG_TAG
#undef  LOG_TAG
#endif
#define LOG_TAG "stemwatch"

#if !defined(PACKAGE)
#define PACKAGE "org.example.stemwatch"
#endif




void data_get_resource_path(const char *file_in, char *file_path_out, int file_path_max);
#endif /* __stemwatch_H__ */
