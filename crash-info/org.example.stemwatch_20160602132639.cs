S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:37

Crash Information
Process Name: stemwatch
PID: 2778
Date: 2016-06-02 13:26:39+0900
Executable File Path: /opt/usr/apps/org.example.stemwatch/bin/stemwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb87c05d0
ebp = 0x00000000, esp = 0xbf97f310
eax = 0x00000000, ebx = 0xb6957e40
ecx = 0xb459d07a, edx = 0x00000000
eip = 0x00000000

Memory Information
MemTotal:      124 KB
MemFree:        43 KB
Buffers:         3 KB
Cached:     207100 KB
VmPeak:      89668 KB
VmSize:      89668 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16392 KB
VmRSS:       16392 KB
VmData:      29216 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32128 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 2778 TID = 2778
2778 2779 2787 

Maps Information
b2c0b000 b2c0c000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b34a9000 b34ab000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnu-i686-1.7.99/module.so
b34ac000 b34d0000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b36f1000 b36ff000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b3700000 b3703000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnu-i686-1.7.99/module.so
b3704000 b3707000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b3f0e000 b3f11000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3f12000 b3f1b000 r-xp /usr/lib/libtbm.so.1.0.0
b3f1c000 b3f1f000 r-xp /usr/lib/libdri2.so.0.0.0
b3f20000 b3f26000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3f27000 b3f32000 r-xp /usr/lib/libdrm.so.2.4.0
b3f33000 b3f65000 r-xp /usr/lib/libsystemd.so.0.0.1
b3f68000 b3f70000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3f71000 b3f8b000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b3f8c000 b3fac000 r-xp /usr/lib/libwidget_service.so.1.0.0
b3fad000 b3fc9000 r-xp /usr/lib/libcom-core.so.0.0.1
b3fca000 b410e000 r-xp /usr/lib/libcairo.so.2.11200.14
b4112000 b4121000 r-xp /usr/lib/libwidget.so.1.0.0
b4122000 b412e000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b412f000 b4142000 r-xp /usr/lib/libalarm.so.0.0.0
b4144000 b4165000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4166000 b416f000 r-xp /usr/lib/libappcore-watch.so.1.1
b4170000 b417b000 r-xp /lib/libnss_files-2.13.so
b43bc000 b43e3000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b43e4000 b4409000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b440a000 b452b000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b453b000 b4571000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4573000 b4576000 r-xp /usr/lib/libiniparser.so.0
b4578000 b4582000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b4583000 b458c000 r-xp /usr/lib/libappsvc.so.0.1.0
b458d000 b4590000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4592000 b4594000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4595000 b4598000 r-xp /usr/lib/libcapi-appfw-alarm.so.0.3.1.0
b4599000 b459e000 r-xp /opt/usr/apps/org.example.stemwatch/bin/stemwatch
b459f000 b45a5000 r-xp /usr/lib/libogg.so.0.7.1
b45a6000 b45d1000 r-xp /usr/lib/libvorbis.so.0.4.3
b45d2000 b46bd000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b46cb000 b46cd000 r-xp /usr/lib/libXau.so.6.0.0
b46ce000 b472e000 r-xp /usr/lib/libssl.so.1.0.0
b4733000 b4764000 r-xp /usr/lib/libidn.so.11.5.44
b4765000 b4775000 r-xp /usr/lib/libcares.so.2.1.0
b4776000 b47df000 r-xp /usr/lib/libsndfile.so.1.0.25
b47e5000 b47ef000 r-xp /usr/lib/libsensord-share.so
b47f0000 b4816000 r-xp /lib/libexpat.so.1.5.2
b4818000 b483f000 r-xp /usr/lib/libpng12.so.0.50.0
b4840000 b4860000 r-xp /usr/lib/libxcb.so.1.1.0
b4861000 b48d0000 r-xp /usr/lib/libcurl.so.4.3.0
b48d2000 b48dd000 r-xp /usr/lib/libethumb.so.1.7.99
b5e3d000 b5f15000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f21000 b5f24000 r-xp /usr/lib/libctxdata.so.0.0.0
b5f25000 b5f3b000 r-xp /usr/lib/libremix.so.0.0.0
b5f3c000 b5f3e000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f3f000 b5f6b000 r-xp /usr/lib/liblua-5.1.so
b5f6c000 b5f76000 r-xp /usr/lib/libembryo.so.1.7.99
b5f77000 b5fbd000 r-xp /usr/lib/libjpeg.so.8.0.2
b5fce000 b5fec000 r-xp /usr/lib/libsensor.so.1.1.0
b5fee000 b6070000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6075000 b60a9000 r-xp /usr/lib/libfontconfig.so.1.5.0
b60ab000 b6106000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6108000 b611e000 r-xp /usr/lib/libfribidi.so.0.3.1
b611f000 b61ab000 r-xp /usr/lib/libfreetype.so.6.11.3
b61af000 b61b2000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b61b3000 b61b9000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b61ba000 b61c0000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61c2000 b61d3000 r-xp /usr/lib/libXext.so.6.4.0
b61d4000 b6308000 r-xp /usr/lib/libX11.so.6.3.0
b630c000 b6311000 r-xp /usr/lib/libXtst.so.6.1.0
b6312000 b631a000 r-xp /usr/lib/libXrender.so.1.3.0
b631b000 b6324000 r-xp /usr/lib/libXrandr.so.2.2.0
b6325000 b6327000 r-xp /usr/lib/libXinerama.so.1.0.0
b6328000 b6336000 r-xp /usr/lib/libXi.so.6.1.0
b6337000 b633b000 r-xp /usr/lib/libXfixes.so.3.1.0
b633c000 b633e000 r-xp /usr/lib/libXgesture.so.7.0.0
b633f000 b6341000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6342000 b6344000 r-xp /usr/lib/libXdamage.so.1.1.0
b6345000 b634e000 r-xp /usr/lib/libXcursor.so.1.0.2
b634f000 b637a000 r-xp /usr/lib/libecore_con.so.1.7.99
b637c000 b6384000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6385000 b6390000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6391000 b6397000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6398000 b63b9000 r-xp /usr/lib/libefreet.so.1.7.99
b63bb000 b63c7000 r-xp /usr/lib/libedbus.so.1.7.99
b63c8000 b6527000 r-xp /usr/lib/libicuuc.so.51.1
b6535000 b673e000 r-xp /usr/lib/libicui18n.so.51.1
b6747000 b67e4000 r-xp /usr/lib/libedje.so.1.7.99
b67e6000 b67f7000 r-xp /usr/lib/libecore_input.so.1.7.99
b67f8000 b67ff000 r-xp /usr/lib/libecore_file.so.1.7.99
b6800000 b6826000 r-xp /usr/lib/libeet.so.1.7.99
b682f000 b6957000 r-xp /usr/lib/libevas.so.1.7.99
b6974000 b69a7000 r-xp /usr/lib/libecore_evas.so.1.7.99
b69a9000 b69ed000 r-xp /usr/lib/libecore_x.so.1.7.99
b69ef000 b6be9000 r-xp /usr/lib/libelementary.so.1.7.99
b6bfa000 b6c00000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6c01000 b6c05000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6c09000 b6c0a000 r-xp /usr/lib/libjournal.so.0.1.0
b6c0b000 b6d53000 r-xp /usr/lib/libxml2.so.2.7.8
b6d5a000 b6d6d000 r-xp /lib/libresolv-2.13.so
b6d71000 b6d8e000 r-xp /lib/libz.so.1.2.5
b6d8f000 b6d92000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d93000 b6d98000 r-xp /usr/lib/libffi.so.5.0.10
b6d99000 b6d9a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d9c000 b6da0000 r-xp /lib/libattr.so.1.1.0
b6da1000 b6fb3000 r-xp /usr/lib/libcrypto.so.1.0.0
b6fce000 b6fef000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6ff0000 b7018000 r-xp /lib/libm-2.13.so
b701a000 b7075000 r-xp /usr/lib/libeina.so.1.7.99
b7078000 b7083000 r-xp /usr/lib/libvconf.so.0.2.45
b7084000 b7087000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b7088000 b70d6000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b70d7000 b7238000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b723c000 b7243000 r-xp /lib/librt-2.13.so
b7246000 b724d000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b724f000 b7269000 r-xp /lib/libgcc_s-4.6.4.so.1
b726a000 b7272000 r-xp /lib/libcrypt-2.13.so
b729b000 b729f000 r-xp /lib/libcap.so.2.21
b72a0000 b72a2000 r-xp /usr/lib/libiri.so
b72a4000 b72d0000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b72d1000 b72f1000 r-xp /usr/lib/libecore.so.1.7.99
b7300000 b7309000 r-xp /usr/lib/libxdgmime.so.1.1.0
b730a000 b742d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b742e000 b7441000 r-xp /usr/lib/libail.so.0.1.0
b7443000 b7468000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b7469000 b7473000 r-xp /lib/libunwind.so.8.0.1
b747d000 b75ee000 r-xp /lib/libc-2.13.so
b75f4000 b763e000 r-xp /usr/lib/libdbus-1.so.3.7.2
b763f000 b7644000 r-xp /usr/lib/libbundle.so.0.1.22
b7645000 b7648000 r-xp /lib/libdl-2.13.so
b764b000 b7650000 r-xp /usr/lib/libsmack.so.1.0.0
b7651000 b76f9000 r-xp /usr/lib/libsqlite3.so.0.8.6
b76fc000 b7716000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7717000 b772e000 r-xp /lib/libpthread-2.13.so
b7732000 b7735000 r-xp /usr/lib/libdlog.so.0.0.0
b7736000 b7746000 r-xp /usr/lib/libaul.so.0.1.0
b7748000 b774e000 r-xp /usr/lib/libappcore-common.so.1.1
b774f000 b7754000 r-xp /usr/lib/libappcore-efl.so.1.1
b7756000 b775b000 r-xp /usr/lib/libsys-assert.so
b775e000 b777c000 r-xp /lib/ld-2.13.so
b777c000 b777d000 r-xp [vdso]
b777f000 b7786000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:2778)
Call Stack Count: 1
 0: ((nil)) (null)
End of Call Stack

Package Information
Package Name: org.example.stemwatch
Package ID : org.example.stemwatch
Version: 1.0.0
Package Type: rpm
App Name: stemwatch
App ID: org.example.stemwatch
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
tension_more_option.c: eext_more_option_item_append(332) > mold is NULL!!
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(1618) > rotary_selector_item is NULL!!
06-02 13:26:39.808+0900 E/EFL     ( 2778): <2778> elm_image.c:1125 elm_image_add() safety check failed: parent == NULL
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(1750) > rotary_selector_item is NULL!!
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_more_option.c: _more_option_data_get(172) > more_option is NULL!!
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_more_option.c: eext_more_option_item_append(332) > mold is NULL!!
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(1618) > rotary_selector_item is NULL!!
06-02 13:26:39.808+0900 E/EFL     ( 2778): <2778> elm_image.c:1125 elm_image_add() safety check failed: parent == NULL
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(1750) > rotary_selector_item is NULL!!
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_more_option.c: _more_option_data_get(172) > more_option is NULL!!
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_more_option.c: eext_more_option_item_append(332) > mold is NULL!!
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(1618) > rotary_selector_item is NULL!!
06-02 13:26:39.808+0900 E/EFL     ( 2778): <2778> elm_image.c:1125 elm_image_add() safety check failed: parent == NULL
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(1750) > rotary_selector_item is NULL!!
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_more_option.c: _more_option_data_get(172) > more_option is NULL!!
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_more_option.c: eext_more_option_item_append(332) > mold is NULL!!
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(1618) > rotary_selector_item is NULL!!
06-02 13:26:39.808+0900 E/EFL     ( 2778): <2778> elm_image.c:1125 elm_image_add() safety check failed: parent == NULL
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(1750) > rotary_selector_item is NULL!!
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_more_option.c: _more_option_data_get(172) > more_option is NULL!!
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_more_option.c: eext_more_option_item_append(332) > mold is NULL!!
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_text_set(1618) > rotary_selector_item is NULL!!
06-02 13:26:39.808+0900 E/EFL     ( 2778): <2778> elm_image.c:1125 elm_image_add() safety check failed: parent == NULL
06-02 13:26:39.808+0900 E/efl-extension( 2778): efl_extension_rotary_selector.c: eext_rotary_selector_item_part_content_set(1750) > rotary_selector_item is NULL!!
06-02 13:26:39.828+0900 E/EFL     ( 2865): eina_module<2865> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
06-02 13:26:39.888+0900 D/W_HOME  ( 2273): main.c: _window_focus_out_cb(869) > focus out
06-02 13:26:39.888+0900 D/W_HOME  ( 2273): main.c: _pause_cb(600) > Paused
06-02 13:26:39.888+0900 D/W_HOME  ( 2273): page.c: page_focus(701) > focus set to 0xb896c5c8
06-02 13:26:39.888+0900 W/W_HOME  ( 2273): main.c: _pause_cb(613) > clock/widget paused
06-02 13:26:39.888+0900 D/W_HOME  ( 2273): clock_view.c: clock_view_event_handler(843) > event:10002 received
06-02 13:26:39.888+0900 E/APPS    ( 2273): apps_main.c: _window_focus_out_cb(313) >  win[23068679], ev->win[23068675]
06-02 13:26:39.898+0900 D/DATA_PROVIDER_MASTER( 2292): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2273 is paused
06-02 13:26:39.898+0900 D/DATA_PROVIDER_MASTER( 2292): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
06-02 13:26:39.948+0900 D/LAUNCH  ( 2865): appcore-efl.c: __do_app(501) > [crash-popup:Application:reset:done]
06-02 13:26:39.948+0900 I/APP_CORE( 2865): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
06-02 13:26:39.948+0900 I/APP_CORE( 2865): appcore-efl.c: __do_app(509) > [APP 2865] Initial Launching, call the resume_cb
06-02 13:26:39.948+0900 D/APP_CORE( 2865): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
06-02 13:26:39.948+0900 D/APP_CORE( 2865): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1800006
06-02 13:26:39.948+0900 D/APP_CORE( 2865): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1800006
06-02 13:26:40.038+0900 D/RESOURCED( 2370): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2865, type = 0
06-02 13:26:40.038+0900 D/RESOURCED( 2370): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2865
06-02 13:26:40.038+0900 I/RESOURCED( 2370): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 2865, oom : 200
06-02 13:26:40.038+0900 E/RESOURCED( 2370): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
06-02 13:26:40.038+0900 E/RESOURCED( 2370): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (2865) didn't have any process list
06-02 13:26:40.038+0900 D/RESOURCED( 2370): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2865, appname = (null)
06-02 13:26:40.038+0900 D/RESOURCED( 2370): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2865
06-02 13:26:40.038+0900 D/AUL_AMD ( 2171): amd_launch.c: __e17_status_handler(1911) > pid(2865) status(3)
06-02 13:26:40.178+0900 D/APP_CORE( 2865): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1800006 fully_obscured 0
06-02 13:26:40.178+0900 D/APP_CORE( 2865): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
06-02 13:26:40.178+0900 D/APP_CORE( 2865): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
06-02 13:26:40.178+0900 D/APP_CORE( 2865): appcore-efl.c: __do_app(470) > [APP 2865] Event: RESUME State: RUNNING
06-02 13:26:40.178+0900 D/LAUNCH  ( 2865): appcore-efl.c: __do_app(557) > [crash-popup:Application:resume:start]
06-02 13:26:40.178+0900 D/LAUNCH  ( 2865): appcore-efl.c: __do_app(567) > [crash-popup:Application:resume:done]
06-02 13:26:40.178+0900 D/LAUNCH  ( 2865): appcore-efl.c: __do_app(569) > [crash-popup:Application:Launching:done]
06-02 13:26:40.178+0900 D/APP_CORE( 2865): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
06-02 13:26:40.178+0900 E/APP_CORE( 2865): appcore-efl.c: __trm_app_info_send_socket(233) > access
06-02 13:26:40.278+0900 E/COM_CORE( 2292): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
06-02 13:26:40.278+0900 D/COM_CORE( 2292): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (51)
06-02 13:26:40.278+0900 D/COM_CORE( 2292): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
06-02 13:26:40.278+0900 D/COM_CORE( 2292): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
06-02 13:26:40.278+0900 D/COM_CORE( 2292): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
06-02 13:26:40.278+0900 D/COM_CORE( 2292): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
06-02 13:26:40.278+0900 E/DATA_PROVIDER_MASTER( 2292): fault_manager.c: check_log_file(90) > [SECURE_LOG] fopen [2]
06-02 13:26:40.278+0900 D/DATA_PROVIDER_MASTER( 2292): package.c: package_is_faulted(693) > [SECURE_LOG] Triggered fault_count, return 1
06-02 13:26:40.278+0900 E/DATA_PROVIDER_MASTER( 2292): fault_manager.c: clear_log_file(76) > [SECURE_LOG] unlink: 2
06-02 13:26:40.278+0900 D/DATA_PROVIDER_MASTER( 2292): slave_life.c: slave_deactivated_by_fault(1200) > [SECURE_LOG] Try to terminate PID: 2778
06-02 13:26:40.278+0900 D/AUL     ( 2292): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : 2778
06-02 13:26:40.278+0900 D/AUL     ( 2292): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(4)
06-02 13:26:40.288+0900 D/AUL_AMD ( 2171): amd_request.c: __request_handler(495) > __request_handler: 4
06-02 13:26:40.288+0900 D/RESOURCED( 2370): proc-noti.c: recv_str(87) > [recv_str,87] str is null
06-02 13:26:40.288+0900 D/RESOURCED( 2370): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2171
06-02 13:26:40.288+0900 D/RESOURCED( 2370): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid (null), pid 2778, type 6 
06-02 13:26:40.288+0900 D/RESOURCED( 2370): proc-main.c: proc_remove_process_list(363) > [proc_remove_process_list,363] found_pid 2778
06-02 13:26:40.288+0900 D/AUL_AMD ( 2171): amd_request.c: __app_process_by_pid(179) > __app_process_by_pid, cmd: 4, pid: 2778, 
06-02 13:26:40.288+0900 D/AUL     ( 2171): app_sock.c: __app_send_raw_with_delay_reply(435) > pid(2778) : cmd(4)
06-02 13:26:40.288+0900 E/AUL     ( 2171): app_sock.c: __connect_client_sock(208) > connect error: 111
06-02 13:26:40.288+0900 E/AUL     ( 2171): app_sock.c: __create_client_sock(174) > cannot connect the client socket: 111
06-02 13:26:40.348+0900 D/APP_CORE( 2865): appcore.c: __prt_ltime(183) > [APP 2865] first idle after reset: 933 msec
06-02 13:26:40.398+0900 E/AUL     ( 2171): app_sock.c: __connect_client_sock(208) > connect error: 111
06-02 13:26:40.398+0900 E/AUL     ( 2171): app_sock.c: __create_client_sock(174) > cannot connect the client socket: 111
06-02 13:26:40.568+0900 I/AUL_PAD ( 2206): sigchild.h: __launchpad_sig_child(142) > dead_pid = 2778 pgid = 2778
06-02 13:26:40.568+0900 I/AUL_PAD ( 2206): sigchild.h: __sigchild_action(123) > dead_pid(2778)
06-02 13:26:40.568+0900 D/AUL_PAD ( 2206): sigchild.h: __send_app_dead_signal(81) > send dead signal done
06-02 13:26:40.568+0900 I/AUL_PAD ( 2206): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-02 13:26:40.568+0900 I/AUL_PAD ( 2206): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-02 13:26:40.568+0900 D/W_HOME  ( 2273): main.c: _dead_cb(542) > PID(2778) is dead
06-02 13:26:40.568+0900 E/W_HOME  ( 2273): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
06-02 13:26:40.568+0900 D/STARTER ( 2268): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 2778)
06-02 13:26:40.698+0900 E/AUL     ( 2171): app_sock.c: __connect_client_sock(208) > connect error: 111
06-02 13:26:40.698+0900 E/AUL     ( 2171): app_sock.c: __create_client_sock(174) > cannot connect the client socket: 111
06-02 13:26:40.698+0900 D/AUL_AMD ( 2171): amd_launch.c: _term_app(883) > terminate packet send error - use SIGKILL
06-02 13:26:40.698+0900 E/AUL_AMD ( 2171): amd_launch.c: _term_app(885) > fail to killing - 2778
06-02 13:26:40.698+0900 D/AUL_AMD ( 2171): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.tizen.crash-popup /usr/apps/org.tizen.crash-popup/bin/crash-popup
06-02 13:26:40.698+0900 D/RUA     ( 2171): rua.c: rua_add_history(179) > rua_add_history start
06-02 13:26:40.698+0900 D/AUL     ( 2292): launch.c: app_request_to_launchpad(295) > launch request result : -1
06-02 13:26:40.698+0900 E/DATA_PROVIDER_MASTER( 2292): slave_life.c: slave_deactivated_by_fault(1203) > [SECURE_LOG] Terminate failed, pid 2778
06-02 13:26:40.698+0900 D/DATA_PROVIDER_MASTER( 2292): instance.c: instance_destroyed(3314) > [SECURE_LOG] Send deleted event - multicast
06-02 13:26:40.698+0900 D/DATA_PROVIDER_MASTER( 2292): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
06-02 13:26:40.698+0900 E/DATA_PROVIDER_MASTER( 2292): instance.c: send_gbar_destroyed_to_client(660) > [SECURE_LOG] GBAR is not created
06-02 13:26:40.698+0900 D/DATA_PROVIDER_MASTER( 2292): instance.c: destroy_instance(791) > [SECURE_LOG] Instance is destroyed (0xb837ea98), slave(0xb83b63d0)
06-02 13:26:40.698+0900 E/DATA_PROVIDER_MASTER( 2292): buffer_handler.c: buffer_handler_unload(700) > [SECURE_LOG] Buffer is not loaded
06-02 13:26:40.698+0900 E/DATA_PROVIDER_MASTER( 2292): buffer_handler.c: buffer_handler_unload(700) > [SECURE_LOG] Buffer is not loaded
06-02 13:26:40.698+0900 D/DATA_PROVIDER_MASTER( 2292): slave_life.c: slave_unload_instance(1705) > [SECURE_LOG] Instance: (-1)0
06-02 13:26:40.698+0900 D/DATA_PROVIDER_MASTER( 2292): slave_rpc.c: slave_deactivate_cb(338) > [SECURE_LOG] Reset handle for -1 (51)
06-02 13:26:40.698+0900 D/COM_CORE( 2292): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(51) for pid(-1)
06-02 13:26:40.698+0900 E/DATA_PROVIDER_MASTER( 2292): slave_rpc.c: slave_async_cb(141) > [SECURE_LOG] Slave is not activated (accidently dead)
06-02 13:26:40.698+0900 E/DATA_PROVIDER_MASTER( 2292): slave_life.c: pause_cb(1822) > [SECURE_LOG] Failed to change the state of the slave
06-02 13:26:40.698+0900 E/COM_CORE( 2292): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
06-02 13:26:40.698+0900 D/WIDGET_VIEWER( 2273): client.c: master_fault_package(85) > [SECURE_LOG] [org.example.stemwatch]
06-02 13:26:40.698+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: widget_fault_handler(6669) > [SECURE_LOG] Faulted: org.example.stemwatch (0xb88e20f0)
06-02 13:26:40.698+0900 E/WIDGET_SERVICE( 2273): widget_service.c: widget_service_get_preview_image_path(1854) > [SECURE_LOG] Failed to get data (org.example.stemwatch)
06-02 13:26:40.698+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: __widget_overlay_faulted(5354) > [SECURE_LOG] Set overlay fault (0xb88e20f0) org.example.stemwatch
06-02 13:26:40.698+0900 D/WIDGET_VIEWER( 2273): client.c: master_deleted(201) > [SECURE_LOG] [org.example.stemwatch]
06-02 13:26:40.698+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: __widget_event_deleted(6142) > [SECURE_LOG] widget is deleted: 0xb88e20f0 (emit signal)
06-02 13:26:40.698+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: __widget_event_deleted(6155) > [SECURE_LOG] Invoke raw delete org.example.stemwatch
06-02 13:26:40.698+0900 D/W_HOME  ( 2273): clock_inf_widget.c: user_del_cb(219) > Faulted: org.example.stemwatch, Current: org.example.stemwatch
06-02 13:26:40.698+0900 D/W_HOME  ( 2273): clock_inf_widget.c: user_del_cb(234) > There is no waiting clock. Try to recover from fault (15)
06-02 13:26:40.698+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: widget_unref(956) > [SECURE_LOG] refcnt: 1 (org.example.stemwatch)
06-02 13:26:40.698+0900 D/WIDGET_VIEWER( 2273): widget_internal.c: _widget_unref(763) > [SECURE_LOG] Handler is released
06-02 13:26:40.698+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: __widget_overlay_clicked_cb(3500) > [SECURE_LOG] Overlay is clicked: (mouse,clicked,1) (overlay,content)
06-02 13:26:40.698+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: __widget_overlay_clicked_cb(3508) > [SECURE_LOG] Activate: [org.example.stemwatch]
06-02 13:26:40.738+0900 D/DATA_PROVIDER_MASTER( 2292): server.c: client_activate_package(6304) > [SECURE_LOG] pid[2273] pkgname[org.example.stemwatch]
06-02 13:26:40.738+0900 D/RUA     ( 2171): rua.c: rua_add_history(247) > rua_add_history ok
06-02 13:26:40.738+0900 I/AUL_AMD ( 2171): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 2778
06-02 13:26:40.738+0900 D/AUL_AMD ( 2171): amd_key.c: _unregister_key_event(161) > ===key stack===
06-02 13:26:40.738+0900 D/AUL     ( 2171): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
06-02 13:26:40.738+0900 E/AUL     ( 2171): simple_util.c: __trm_app_info_send_socket(264) > access
06-02 13:26:40.798+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: activate_ret_cb(3420) > [SECURE_LOG] Activated (org.example.stemwatch): 0
06-02 13:26:40.798+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: activate_ret_cb(3450) > [SECURE_LOG] Added Handle: (0xb8a7e368) 0xb88e20f0
06-02 13:26:40.798+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: __widget_overlay_loading(5252) > [SECURE_LOG] Loading overlay is disabled
06-02 13:26:40.798+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: widget_unref(956) > [SECURE_LOG] refcnt: 2 (org.example.stemwatch)
06-02 13:26:40.828+0900 D/DATA_PROVIDER_MASTER( 2292): server.c: client_new(1409) > [SECURE_LOG] pid[2273] period[170.804138] pkgname[org.example.stemwatch] content[] cluster[user,created] category[default] period[-1.000000]
06-02 13:26:40.858+0900 D/DATA_PROVIDER_MASTER( 2292): util.c: util_free_space(163) > [SECURE_LOG] Available size: 4409442304, f_bsize: 4096, f_bavail: 1076524
06-02 13:26:40.858+0900 D/DATA_PROVIDER_MASTER( 2292): package.c: assign_new_slave(1172) > [SECURE_LOG] New slave[6_170.868614] is assigned for org.example.stemwatch (using org.example.stemwatch / abi[app] / accel[use-sw]
06-02 13:26:40.858+0900 D/DATA_PROVIDER_MASTER( 2292): slave_life.c: slave_load_instance(1684) > [SECURE_LOG] Instance: (-1)1
06-02 13:26:40.888+0900 E/DATA_PROVIDER_MASTER( 2292): slave_life.c: slave_activate(892) > [SECURE_LOG] Launch App [org.example.stemwatch]
06-02 13:26:40.888+0900 D/AUL     ( 2292): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.example.stemwatch
06-02 13:26:40.888+0900 D/AUL     ( 2292): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
06-02 13:26:40.888+0900 D/AUL_AMD ( 2171): amd_request.c: __request_handler(495) > __request_handler: 0
06-02 13:26:40.888+0900 D/AUL_AMD ( 2171): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.stemwatch
06-02 13:26:40.898+0900 D/AUL     ( 2171): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2292, pid = 2292
06-02 13:26:40.898+0900 D/AUL_AMD ( 2171): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
06-02 13:26:40.898+0900 E/AUL_AMD ( 2171): amd_launch.c: invoke_dbus_method_sync(1190) > dbus_connection_send error(org.freedesktop.DBus.Error.ServiceUnknown:The name org.tizen.system.coord was not provided by any .service files)
06-02 13:26:40.898+0900 D/AUL_AMD ( 2171): amd_launch.c: _start_app(1690) > org.tizen.system.coord.rotation-Degree : -74
06-02 13:26:40.898+0900 D/AUL_AMD ( 2171): amd_launch.c: _start_app(1785) > process_pool: false
06-02 13:26:40.898+0900 D/AUL_AMD ( 2171): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
06-02 13:26:40.898+0900 D/AUL_AMD ( 2171): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.stemwatch
06-02 13:26:40.898+0900 D/AUL_AMD ( 2171): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
06-02 13:26:40.898+0900 D/AUL     ( 2171): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
06-02 13:26:40.898+0900 D/AUL_PAD ( 2206): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.stemwatch
06-02 13:26:40.898+0900 D/AUL_PAD ( 2206): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
06-02 13:26:40.908+0900 D/AUL_PAD ( 2206): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 2868 /opt/usr/apps/org.example.stemwatch/bin/stemwatch
06-02 13:26:40.908+0900 D/AUL_PAD ( 2206): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
06-02 13:26:40.908+0900 D/AUL_PAD ( 2868): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
06-02 13:26:40.908+0900 D/AUL_PAD ( 2868): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
06-02 13:26:40.908+0900 D/AUL_PAD ( 2868): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.stemwatch / pkg_type : rpm / app_path : /opt/usr/apps/org.example.stemwatch/bin/stemwatch 
06-02 13:26:40.918+0900 D/AUL_PAD ( 2868): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
06-02 13:26:40.918+0900 D/AUL_PAD ( 2868): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.stemwatch/bin/stemwatch##
06-02 13:26:40.918+0900 D/AUL_PAD ( 2868): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
06-02 13:26:40.918+0900 D/AUL_PAD ( 2868): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : name##
06-02 13:26:40.918+0900 D/AUL_PAD ( 2868): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : secured##
06-02 13:26:40.928+0900 D/AUL_PAD ( 2868): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : abi##
06-02 13:26:40.928+0900 D/AUL_PAD ( 2868): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : hw-acceleration##
06-02 13:26:40.928+0900 D/AUL_PAD ( 2868): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 12 : __AUL_STARTTIME__##
06-02 13:26:40.928+0900 D/AUL_PAD ( 2868): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 14 : __AUL_CALLER_PID__##
06-02 13:26:40.928+0900 D/LAUNCH  ( 2868): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.stemwatch/bin/stemwatch:Platform:launchpad:done]
06-02 13:26:40.928+0900 I/efl-extension( 2868): efl_extension.c: eext_mod_init(39) > Init
06-02 13:26:41.008+0900 D/AUL_PAD ( 2206): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
06-02 13:26:41.008+0900 D/AUL_PAD ( 2206): sigchild.h: __send_app_launch_signal(112) > send launch signal done
06-02 13:26:41.008+0900 D/AUL_PAD ( 2206): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
06-02 13:26:41.008+0900 D/AUL     ( 2171): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
06-02 13:26:41.008+0900 E/AUL     ( 2171): simple_util.c: __trm_app_info_send_socket(264) > access
06-02 13:26:41.008+0900 D/AUL_AMD ( 2171): amd_request.c: __request_handler(495) > __request_handler: 31
06-02 13:26:41.008+0900 E/AUL_AMD ( 2171): amd_status.c: _status_get_cmdline(554) > cmdline : /opt/usr/apps/org.example.stemwatch/bin/stemwatch
06-02 13:26:41.008+0900 E/AUL_AMD ( 2171): amd_status.c: _status_get_cmdline(557) > pkt->data : /opt/usr/apps/org.example.stemwatch/bin/stemwatch
06-02 13:26:41.008+0900 D/AUL_AMD ( 2171): amd_request.c: __request_handler(740) > APP_GET_CMDLINE : 2868 : 0
06-02 13:26:41.008+0900 D/RESOURCED( 2370): proc-noti.c: recv_str(87) > [recv_str,87] str is null
06-02 13:26:41.008+0900 D/RESOURCED( 2370): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2171
06-02 13:26:41.008+0900 D/RESOURCED( 2370): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.stemwatch, pid 2868, type 4 
06-02 13:26:41.008+0900 D/RESOURCED( 2370): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.stemwatch, 2868
06-02 13:26:41.008+0900 D/RESOURCED( 2370): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.stemwatch with pkgname
06-02 13:26:41.008+0900 E/RESOURCED( 2370): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 379
06-02 13:26:41.008+0900 D/RESOURCED( 2370): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
06-02 13:26:41.008+0900 D/AUL     ( 2292): launch.c: app_request_to_launchpad(295) > launch request result : 2868
06-02 13:26:41.008+0900 D/DATA_PROVIDER_MASTER( 2292): slave_life.c: slave_activate(925) > [SECURE_LOG] Slave org.example.stemwatch is launched with 2868 as 6_170.868614
06-02 13:26:41.008+0900 D/DATA_PROVIDER_MASTER( 2292): slave_rpc.c: slave_rpc_async_request(416) > [SECURE_LOG] RPC handle is not ready to use it
06-02 13:26:41.008+0900 D/AUL     ( 2868): app_sock.c: __app_send_cmd_with_result(618) > recv result  = 58
06-02 13:26:41.008+0900 D/AUL     ( 2868): pkginfo.c: aul_app_get_cmdline_bypid(308) > cmdline : /opt/usr/apps/org.example.stemwatch/bin/stemwatch
06-02 13:26:41.008+0900 D/AUL     ( 2868): app_sock.c: __create_server_sock(136) > pg path - already exists
06-02 13:26:41.008+0900 D/WATCH_CORE( 2868): appcore-watch.c: __watch_core_widget_init(1003) > Initialize the widget
06-02 13:26:41.018+0900 D/WIDGET_SERVICE( 2868): widget_conf.c: conf_path(1069) > [SECURE_LOG] Selected conf file: /usr/share/data-provider-master/360x360/conf.ini
06-02 13:26:41.018+0900 D/WIDGET_SERVICE( 2868): widget_conf.c: minimum_period_handler(445) > [SECURE_LOG] Minimum period: 1.000000
06-02 13:26:41.018+0900 D/WIDGET_SERVICE( 2868): widget_conf.c: default_period_handler(485) > [SECURE_LOG] Default Period: -1.000000
06-02 13:26:41.018+0900 D/WIDGET_SERVICE( 2868): widget_conf.c: default_packet_time_handler(493) > [SECURE_LOG] Default packet time: 0.000100
06-02 13:26:41.018+0900 D/WIDGET_SERVICE( 2868): widget_conf.c: slave_ttl_handler(532) > [SECURE_LOG] Slave TTL: 0.000000
06-02 13:26:41.018+0900 D/WIDGET_SERVICE( 2868): widget_conf.c: slave_activate_time_handler(540) > [SECURE_LOG] Slave activate time: 30.000000
06-02 13:26:41.018+0900 D/WIDGET_SERVICE( 2868): widget_conf.c: slave_relaunch_time_handler(556) > [SECURE_LOG] Slave relaunch time: 3.000000
06-02 13:26:41.018+0900 D/WIDGET_SERVICE( 2868): widget_conf.c: ping_time_handler(943) > [SECURE_LOG] Default ping time: 240.000000
06-02 13:26:41.018+0900 D/WIDGET_SERVICE( 2868): widget_conf.c: input_path_handler(916) > [SECURE_LOG] Specifying the input device [0]
06-02 13:26:41.018+0900 D/WIDGET_SERVICE( 2868): widget_conf.c: premultiplied_handler(959) > [SECURE_LOG] Premultiplied: 0
06-02 13:26:41.018+0900 D/WIDGET_PROVIDER_APP( 2868): client.c: is_watchapp(1227) > [SECURE_LOG] component type: watchapp
06-02 13:26:41.018+0900 D/WIDGET_PROVIDER_APP( 2868): client.c: is_watchapp(1230) > [SECURE_LOG] this app is watch app
06-02 13:26:41.018+0900 D/WIDGET_PROVIDER_APP( 2868): client.c: client_init_sync(1336) > [SECURE_LOG] Name assigned: 2868.171.028686 (app)
06-02 13:26:41.018+0900 D/WIDGET_PROVIDER_APP( 2868): client.c: client_init_sync(1337) > [SECURE_LOG] Secured: true
06-02 13:26:41.018+0900 D/WIDGET_PROVIDER_APP( 2868): client.c: client_init_sync(1338) > [SECURE_LOG] hw-acceleration: use-sw
06-02 13:26:41.018+0900 D/COM_CORE( 2868): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [17] New TCB created: R(18), W(19)
06-02 13:26:41.018+0900 D/COM_CORE( 2292): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [51] New TCB created: R(52), W(53)
06-02 13:26:41.038+0900 D/COM_CORE( 2292): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 51 (server: 4)
06-02 13:26:41.038+0900 D/COM_CORE( 2868): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 17 (server: -1)
06-02 13:26:41.058+0900 D/WIDGET_SERVICE( 2868): util_x11.c: widget_util_get_drm_fd(401) > [SECURE_LOG] DRM Magic: 0x13
06-02 13:26:41.058+0900 D/WIDGET_PROVIDER( 2868): widget_provider.c: connected_cb(1199) > [SECURE_LOG] Connected (0xb4125de0) 17
06-02 13:26:41.058+0900 D/WIDGET_PROVIDER( 2868): widget_provider.c: widget_provider_send_hello_sync(1524) > [SECURE_LOG] name[2868.171.028686]
06-02 13:26:41.058+0900 D/WIDGET_PROVIDER( 2868): widget_provider.c: widget_provider_send_hello_sync(1538) > [SECURE_LOG] Accel[use-sw], abi[app]
06-02 13:26:41.058+0900 D/COM_CORE( 2292): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [56] New TCB created: R(57), W(58)
06-02 13:26:41.058+0900 D/AUL_AMD ( 2171): amd_request.c: __request_handler(495) > __request_handler: 15
06-02 13:26:41.068+0900 D/AUL_AMD ( 2171): amd_status.c: _status_get_appid_bypid(432) > [SECURE_LOG] appid for 2868 is org.example.stemwatch
06-02 13:26:41.068+0900 D/AUL_AMD ( 2171): amd_request.c: __request_handler(671) > APP_GET_APPID_BYPID : 2868 : 0
06-02 13:26:41.068+0900 D/AUL     ( 2292): app_sock.c: __app_send_cmd_with_result(618) > recv result  = 30
06-02 13:26:41.068+0900 D/DATA_PROVIDER_MASTER( 2292): server.c: slave_hello_sync_prepare(8191) > [SECURE_LOG] Sync context created: org.example.stemwatch (2868)
06-02 13:26:41.068+0900 D/COM_CORE( 2292): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 56 (server: 4)
06-02 13:26:41.078+0900 D/DATA_PROVIDER_MASTER( 2292): server.c: slave_hello_sync(8248) > [SECURE_LOG] New slave[2868.171.028686](2868) is arrived.
06-02 13:26:41.078+0900 D/AUL_AMD ( 2171): amd_request.c: __request_handler(495) > __request_handler: 15
06-02 13:26:41.078+0900 D/AUL_AMD ( 2171): amd_status.c: _status_get_appid_bypid(432) > [SECURE_LOG] appid for 2868 is org.example.stemwatch
06-02 13:26:41.078+0900 D/AUL_AMD ( 2171): amd_request.c: __request_handler(671) > APP_GET_APPID_BYPID : 2868 : 0
06-02 13:26:41.078+0900 D/AUL     ( 2292): app_sock.c: __app_send_cmd_with_result(618) > recv result  = 30
06-02 13:26:41.078+0900 D/DATA_PROVIDER_MASTER( 2292): server.c: slave_hello_sync(8352) > [SECURE_LOG] Hello sync context found: org.example.stemwatch
06-02 13:26:41.078+0900 D/AUL_AMD ( 2171): amd_request.c: __request_handler(495) > __request_handler: 15
06-02 13:26:41.088+0900 D/AUL_AMD ( 2171): amd_status.c: _status_get_appid_bypid(432) > [SECURE_LOG] appid for 2868 is org.example.stemwatch
06-02 13:26:41.088+0900 D/AUL_AMD ( 2171): amd_request.c: __request_handler(671) > APP_GET_APPID_BYPID : 2868 : 0
06-02 13:26:41.088+0900 D/AUL     ( 2292): app_sock.c: __app_send_cmd_with_result(618) > recv result  = 30
06-02 13:26:41.088+0900 D/DATA_PROVIDER_MASTER( 2292): server.c: slave_hello_sync(8418) > [SECURE_LOG] [org.example.stemwatch] Instance Count: 1
06-02 13:26:41.098+0900 D/DATA_PROVIDER_MASTER( 2292): slave_life.c: slave_set_valid(2155) > [SECURE_LOG] slave is set valid
06-02 13:26:41.098+0900 D/DATA_PROVIDER_MASTER( 2292): slave_rpc.c: slave_rpc_update_handle(518) > [SECURE_LOG] SLAVE: New handle assigned for 2868, 51
06-02 13:26:41.098+0900 D/DATA_PROVIDER_MASTER( 2292): package.c: slave_activated_cb(154) > [SECURE_LOG] Do not need to reactivate instances
06-02 13:26:41.098+0900 D/DATA_PROVIDER_MASTER( 2292): server.c: slave_hello_sync(8448) > [SECURE_LOG] Slave is activated by request: 2868 (org.example.stemwatch)/(2868.171.028686)
06-02 13:26:41.098+0900 D/DATA_PROVIDER_MASTER( 2292): instance.c: instance_watch_change_package_info(4000) > [SECURE_LOG] Package information is not touched (org.example.stemwatch)
06-02 13:26:41.098+0900 D/DATA_PROVIDER_MASTER( 2292): instance.c: instance_duplicate_packet_create(1109) > [SECURE_LOG] [TODO] Instance package info: 0xb83b6950:org.example.stemwatch
06-02 13:26:41.098+0900 D/DATA_PROVIDER_MASTER( 2292): instance.c: instance_duplicate_packet_create(1137) > [SECURE_LOG] [TODO] Instance request_state is not touched
06-02 13:26:41.098+0900 D/DATA_PROVIDER_MASTER( 2292): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
06-02 13:26:41.098+0900 D/COM_CORE( 2868): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2292, fd: -1
06-02 13:26:41.098+0900 D/COM_CORE( 2868): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 165 bytes (pid: 2292), fd: -1
06-02 13:26:41.098+0900 D/COM_CORE( 2868): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
06-02 13:26:41.098+0900 D/WIDGET_PROVIDER_APP( 2868): client.c: method_new(475) > [SECURE_LOG] Create: pkgname[org.example.stemwatch], id[file:///opt/usr/share/live_magazine/org.example.stemwatch_2273_170.804138.png], content[], timeout[10], has_script[0], period[0.000000], cluster[user,created], category[default], skip[1], abi[app], size: 360x360, ori: 0
06-02 13:26:41.098+0900 D/WATCH_CORE( 2868): appcore-watch.c: __widget_create(870) > widget_create
06-02 13:26:41.098+0900 W/CAPI_WATCH_APPLICATION( 2868): watch_app_main.c: _watch_core_create(205) > _watch_core_create
06-02 13:26:41.098+0900 D/WIDGET  ( 2868): binder.c: load_ecore_evas_function(98) > [SECURE_LOG] pixmap_allocfunc_new is not found
06-02 13:26:41.098+0900 D/WIDGET  ( 2868): binder.c: load_ecore_evas_function(103) > [SECURE_LOG] allocfunc_with_stirde_new is not found
06-02 13:26:41.098+0900 D/WIDGET_PROVIDER( 2868): widget_provider_buffer.c: widget_provider_buffer_create(2015) > [SECURE_LOG] acquire_buffer: [WIDGET] file:///opt/usr/share/live_magazine/org.example.stemwatch_2273_170.804138.png, handler: 0xb41194d0
06-02 13:26:41.098+0900 D/WIDGET  ( 2868): binder.c: binder_ecore_evas_new(522) > [SECURE_LOG] Preferred engine: (null) (opengl or opengl_x11)
06-02 13:26:41.098+0900 D/WIDGET_PROVIDER( 2868): widget_provider_buffer.c: widget_provider_buffer_acquire(2087) > [SECURE_LOG] acquire_buffer: [WIDGET] file:///opt/usr/share/live_magazine/org.example.stemwatch_2273_170.804138.png, 1x1, size: 4, handler: 0xb41194d0
06-02 13:26:41.108+0900 E/COM_CORE( 2292): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
06-02 13:26:41.108+0900 D/COM_CORE( 2292): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (56)
06-02 13:26:41.108+0900 D/COM_CORE( 2292): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [61] New TCB created: R(62), W(63)
06-02 13:26:41.108+0900 D/COM_CORE( 2292): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
06-02 13:26:41.108+0900 D/COM_CORE( 2292): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
06-02 13:26:41.108+0900 D/COM_CORE( 2292): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
06-02 13:26:41.108+0900 D/COM_CORE( 2292): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
06-02 13:26:41.108+0900 D/COM_CORE( 2292): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(56) for pid(-1)
06-02 13:26:41.108+0900 E/COM_CORE( 2292): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
06-02 13:26:41.118+0900 D/COM_CORE( 2292): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 61 (server: 4)
06-02 13:26:41.118+0900 D/DATA_PROVIDER_MASTER( 2292): buffer_handler.c: buffer_handler_resize(1047) > [SECURE_LOG] Buffer size is updated[1x1]
06-02 13:26:41.118+0900 D/DATA_PROVIDER_MASTER( 2292): buffer_handler.c: load_pixmap_buffer(539) > [SECURE_LOG] Loaded pixmap(info->id): pixmap://14680094:4
06-02 13:26:41.118+0900 D/COM_CORE( 2868): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2292, fd: -1
06-02 13:26:41.118+0900 D/COM_CORE( 2868): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 24 bytes (pid: 2292), fd: -1
06-02 13:26:41.118+0900 D/COM_CORE( 2868): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
06-02 13:26:41.118+0900 D/WIDGET_PROVIDER( 2868): fb.c: fb_create(610) > [SECURE_LOG] PIXMAP: 14680094
06-02 13:26:41.118+0900 D/WIDGET_PROVIDER( 2868): widget_provider_buffer.c: send_acquire_request(148) > [SECURE_LOG] type: 0x0, name: 2868.171.028686, pkgname[org.example.stemwatch], id[file:///opt/usr/share/live_magazine/org.example.stemwatch_2273_170.804138.png], w[1], h[1], size[4], buffer_id[pixmap://14680094:4], fb[0xb87d82e0]
06-02 13:26:41.118+0900 D/WIDGET_PROVIDER( 2868): fb.c: create_gem(509) > [SECURE_LOG] dri2_buffer: 0xb87d8468, name: 0x10, 1x1 (1x1), pitch: 4, buf_count: 1, gem: 0xb87d8370
06-02 13:26:41.118+0900 D/WIDGET  ( 2868): binder.c: alloc_fb(430) > [SECURE_LOG] HW Accelerated buffer is created 0xb87d84e0, (1x1)
06-02 13:26:41.118+0900 E/COM_CORE( 2292): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
06-02 13:26:41.118+0900 D/COM_CORE( 2292): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (61)
06-02 13:26:41.118+0900 D/COM_CORE( 2292): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
06-02 13:26:41.118+0900 D/COM_CORE( 2292): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
06-02 13:26:41.118+0900 D/COM_CORE( 2292): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
06-02 13:26:41.118+0900 D/COM_CORE( 2292): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
06-02 13:26:41.118+0900 D/COM_CORE( 2292): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(61) for pid(-1)
06-02 13:26:41.118+0900 E/COM_CORE( 2292): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
06-02 13:26:41.118+0900 D/WIDGET  ( 2868): binder.c: load_update_function(128) > [SECURE_LOG] App detected
06-02 13:26:41.118+0900 D/WIDGET_PROVIDER( 2868): fb.c: destroy_gem(524) > [SECURE_LOG] unref pixmap bo
06-02 13:26:41.118+0900 D/WIDGET  ( 2868): binder.c: free_fb(481) > [SECURE_LOG] HW Accelerated buffer is destroyed
06-02 13:26:41.118+0900 D/COM_CORE( 2292): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [56] New TCB created: R(57), W(58)
06-02 13:26:41.128+0900 D/COM_CORE( 2292): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 56 (server: 4)
06-02 13:26:41.128+0900 D/DATA_PROVIDER_MASTER( 2292): buffer_handler.c: destroy_pixmap(343) > [SECURE_LOG] pixmap 14680094
06-02 13:26:41.128+0900 D/COM_CORE( 2868): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2292, fd: -1
06-02 13:26:41.128+0900 D/COM_CORE( 2868): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2292), fd: -1
06-02 13:26:41.128+0900 D/COM_CORE( 2868): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
06-02 13:26:41.128+0900 D/WIDGET  ( 2868): widget.c: widget_viewer_release_buffer(609) > [SECURE_LOG] Release buffer: -1 (0)
06-02 13:26:41.128+0900 D/WIDGET  ( 2868): binder.c: alloc_fb(409) > [SECURE_LOG] Size of ee is updated: 360x360 (info: 0xb87d84e0)
06-02 13:26:41.128+0900 D/WIDGET_PROVIDER( 2868): widget_provider_buffer.c: widget_provider_buffer_acquire(2087) > [SECURE_LOG] acquire_buffer: [WIDGET] file:///opt/usr/share/live_magazine/org.example.stemwatch_2273_170.804138.png, 360x360, size: 4, handler: 0xb41194d0
06-02 13:26:41.128+0900 D/COM_CORE( 2292): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [61] New TCB created: R(62), W(63)
06-02 13:26:41.128+0900 D/WIDGET_VIEWER( 2273): client.c: master_update_id(1650) > [SECURE_LOG] Update ID(file:///opt/usr/share/live_magazine/org.example.stemwatch_2273_170.804138.png) for 170.804138
06-02 13:26:41.138+0900 D/COM_CORE( 2292): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 61 (server: 4)
06-02 13:26:41.138+0900 D/DATA_PROVIDER_MASTER( 2292): buffer_handler.c: buffer_handler_resize(1047) > [SECURE_LOG] Buffer size is updated[360x360]
06-02 13:26:41.138+0900 D/DATA_PROVIDER_MASTER( 2292): buffer_handler.c: load_pixmap_buffer(539) > [SECURE_LOG] Loaded pixmap(info->id): pixmap://14680096:4
06-02 13:26:41.138+0900 D/COM_CORE( 2868): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2292, fd: -1
06-02 13:26:41.138+0900 D/COM_CORE( 2868): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 24 bytes (pid: 2292), fd: -1
06-02 13:26:41.138+0900 D/COM_CORE( 2868): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
06-02 13:26:41.138+0900 D/WIDGET_PROVIDER( 2868): fb.c: fb_create(610) > [SECURE_LOG] PIXMAP: 14680096
06-02 13:26:41.138+0900 D/WIDGET_PROVIDER( 2868): widget_provider_buffer.c: send_acquire_request(148) > [SECURE_LOG] type: 0x0, name: 2868.171.028686, pkgname[org.example.stemwatch], id[file:///opt/usr/share/live_magazine/org.example.stemwatch_2273_170.804138.png], w[360], h[360], size[4], buffer_id[pixmap://14680096:4], fb[0xb87d8370]
06-02 13:26:41.138+0900 D/WIDGET_PROVIDER( 2868): fb.c: create_gem(509) > [SECURE_LOG] dri2_buffer: 0xb87d29b8, name: 0x10, 360x360 (360x360), pitch: 1440, buf_count: 1, gem: 0xb87d2920
06-02 13:26:41.138+0900 D/WIDGET  ( 2868): binder.c: alloc_fb(430) > [SECURE_LOG] HW Accelerated buffer is created 0xb87d84e0, (360x360)
06-02 13:26:41.148+0900 E/COM_CORE( 2292): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
06-02 13:26:41.148+0900 D/COM_CORE( 2292): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (56)
06-02 13:26:41.148+0900 D/COM_CORE( 2292): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
06-02 13:26:41.148+0900 D/COM_CORE( 2292): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
06-02 13:26:41.148+0900 D/COM_CORE( 2292): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
06-02 13:26:41.148+0900 D/COM_CORE( 2292): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
06-02 13:26:41.148+0900 D/COM_CORE( 2292): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(56) for pid(-1)
06-02 13:26:41.148+0900 E/COM_CORE( 2292): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
06-02 13:26:41.148+0900 E/COM_CORE( 2292): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
06-02 13:26:41.148+0900 D/COM_CORE( 2292): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (61)
06-02 13:26:41.148+0900 D/COM_CORE( 2292): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
06-02 13:26:41.148+0900 D/COM_CORE( 2292): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
06-02 13:26:41.148+0900 D/COM_CORE( 2292): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
06-02 13:26:41.148+0900 D/COM_CORE( 2292): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
06-02 13:26:41.148+0900 D/COM_CORE( 2292): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(61) for pid(-1)
06-02 13:26:41.148+0900 E/COM_CORE( 2292): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
06-02 13:26:41.188+0900 E/WIDGET_VIEWER( 2273): client.c: master_created(1711) > [SECURE_LOG] [170.804138] pkgname: org.example.stemwatch, id: file:///opt/usr/share/live_magazine/org.example.stemwatch_2273_170.804138.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
06-02 13:26:41.188+0900 D/WIDGET_VIEWER( 2273): fb.c: fb_create(376) > [SECURE_LOG] PIXMAP-SHMID: 0 is gotten (0)
06-02 13:26:41.188+0900 D/WIDGET_VIEWER( 2273): widget.c: _widget_set_visibility(1143) > [SECURE_LOG] [org.example.stemwatch] visibility is changed 0x[0]
06-02 13:26:41.188+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: __widget_created_cb(4977) > [SECURE_LOG] Invoke raw create org.example.stemwatch
06-02 13:26:41.188+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: widget_unref(956) > [SECURE_LOG] refcnt: 1 (org.example.stemwatch)
06-02 13:26:41.188+0900 E/WIDGET_VIEWER( 2273): fb.c: fb_is_created(425) > [SECURE_LOG] access: 11 ((null))
06-02 13:26:41.188+0900 D/WIDGET_VIEWER( 2273): widget.c: widget_viewer_get_size_type(2679) > [SECURE_LOG] FB is not created yet, but give its size to the caller: 360x360
06-02 13:26:41.218+0900 D/DATA_PROVIDER_MASTER( 2292): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
06-02 13:26:41.248+0900 D/WIDGET_VIEWER( 2273): fb.c: fb_create(376) > [SECURE_LOG] PIXMAP-SHMID: 14680094 is gotten (4)
06-02 13:26:41.248+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: __widget_event_widget_size_changed(6207) > [SECURE_LOG] widget LB size is changed
06-02 13:26:41.308+0900 E/WIDGET_VIEWER( 2273): widget.c: widget_viewer_get_size_type(2687) > [SECURE_LOG] widget_service_get_size_type failed : -22
06-02 13:26:41.308+0900 E/WIDGET_EVAS( 2273): widget_viewer_evas.c: __widget_event_widget_updated(5824) > [SECURE_LOG] Size is not valid FFFF
06-02 13:26:41.398+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: __widget_animation_done_cb(3470) > [SECURE_LOG] Animation finished
06-02 13:26:41.398+0900 D/WIDGET_VIEWER( 2273): fb.c: fb_create(376) > [SECURE_LOG] PIXMAP-SHMID: 14680096 is gotten (4)
06-02 13:26:41.398+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: __widget_event_widget_size_changed(6207) > [SECURE_LOG] widget LB size is changed
06-02 13:26:41.398+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: acquire_widget_pixmap_cb(4751) > [SECURE_LOG] fillset: 360x360
06-02 13:26:41.398+0900 D/WIDGET_EVAS( 2273): widget_viewer_evas.c: widget_unref(956) > [SECURE_LOG] refcnt: 1 (org.example.stemwatch)
06-02 13:26:41.538+0900 I/GESTURE ( 2017): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-02 13:26:41.588+0900 D/EFL     ( 2865): ecore_x<2865> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=171542 button=1
06-02 13:26:41.778+0900 E/EFL     ( 2868): eina_module<2868> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
06-02 13:26:41.798+0900 D/EFL     ( 2865): ecore_x<2865> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=171667 button=1
06-02 13:26:41.798+0900 E/EFL     ( 2865): eina_module<2865> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
06-02 13:26:42.008+0900 D/AUL_AMD ( 2171): amd_launch.c: __grab_timeout_handler(1212) > pid(2868) ecore_x_pointer_ungrab
06-02 13:26:42.008+0900 D/AUL_AMD ( 2171): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.example.stemwatch /opt/usr/apps/org.example.stemwatch/bin/stemwatch
06-02 13:26:42.008+0900 D/RUA     ( 2171): rua.c: rua_add_history(179) > rua_add_history start
06-02 13:26:42.038+0900 D/RUA     ( 2171): rua.c: rua_add_history(247) > rua_add_history ok
06-02 13:26:42.248+0900 I/GESTURE ( 2017): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
06-02 13:26:42.348+0900 D/WATCH_CORE( 2868): appcore-watch.c: __widget_create(888) > widget_create done
06-02 13:26:42.348+0900 D/ALARM_MANAGER( 2868): alarm-lib.c: alarmmgr_init(326) > [SECURE_LOG] Enter
06-02 13:26:42.468+0900 D/EFL     ( 2865): ecore_x<2865> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=172293 button=1
06-02 13:26:42.468+0900 D/EFL     ( 2865): ecore_x<2865> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=172381 button=1
06-02 13:26:42.588+0900 D/ALARM_MANAGER( 2868): alarm-lib.c: __sub_init(312) > [SECURE_LOG] alarm_context.pid is set to processID, 2868.
06-02 13:26:42.588+0900 D/ALARM_MANAGER( 2868): alarm-lib.c: alarmmgr_init(369) > [SECURE_LOG] [alarm-lib]: dbus own name: ALARM.aorg.aexample.astemwatch
06-02 13:26:42.588+0900 D/ALARM_MANAGER( 2868): alarm-lib.c: alarmmgr_init(397) > [SECURE_LOG] Leave
06-02 13:26:42.588+0900 E/WIDGET_PROVIDER( 2868): widget_provider.c: widget_provider_send_hello_sync(1600) > [SECURE_LOG] #widget_create return [0]
06-02 13:26:42.598+0900 D/WIDGET_PROVIDER( 2868): widget_provider.c: initialize_provider(1260) > [SECURE_LOG] Slave is initialized
06-02 13:26:42.598+0900 E/WIDGET_PROVIDER_APP( 2868): client.c: client_init_sync(1342) > [SECURE_LOG] widget_provider_init return [0]
06-02 13:26:42.598+0900 D/WATCH_CORE( 2868): appcore-watch.c: __watch_core_widget_init(1014) > succeded to initialize the widget
06-02 13:26:42.598+0900 D/WATCH_CORE( 2868): appcore-watch-signal.c: _watch_core_listen_alpm_handler(141) > watch_core_listen_deviced_alpm
06-02 13:26:42.948+0900 W/CRASH_MANAGER( 2738): worker.c: worker_job(1189) > 1102778737465146484159
