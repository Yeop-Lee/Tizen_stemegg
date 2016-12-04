S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:37

Crash Information
Process Name: stemwatch
PID: 4407
Date: 2016-05-22 22:04:10+0900
Executable File Path: /opt/usr/apps/org.example.stemwatch/bin/stemwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xa

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb9134558, esi = 0x0000000a
ebp = 0xbf802bd8, esp = 0xbf802bc0
eax = 0x00000000, ebx = 0xb70ac3bc
ecx = 0x00000000, edx = 0x00000001
eip = 0xb7080750

Memory Information
MemTotal:      124 KB
MemFree:        53 KB
Buffers:         4 KB
Cached:     162036 KB
VmPeak:      90788 KB
VmSize:      90788 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16884 KB
VmRSS:       16884 KB
VmData:      30356 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32112 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 4407 TID = 4407
4407 4409 4415 

Maps Information
b2c46000 b2c47000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b34e5000 b34e7000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnu-i686-1.7.99/module.so
b34e8000 b350c000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b372d000 b373b000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b373c000 b373f000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnu-i686-1.7.99/module.so
b3740000 b3743000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b3f48000 b3f4b000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3f4c000 b3f55000 r-xp /usr/lib/libtbm.so.1.0.0
b3f56000 b3f5c000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3f5d000 b3f68000 r-xp /usr/lib/libdrm.so.2.4.0
b3f69000 b3f9b000 r-xp /usr/lib/libsystemd.so.0.0.1
b3f9e000 b3fa6000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3fa7000 b3fc1000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b3fc2000 b3fe2000 r-xp /usr/lib/libwidget_service.so.1.0.0
b3fe3000 b3fff000 r-xp /usr/lib/libcom-core.so.0.0.1
b4000000 b4144000 r-xp /usr/lib/libcairo.so.2.11200.14
b4148000 b4157000 r-xp /usr/lib/libwidget.so.1.0.0
b4158000 b4164000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b4165000 b4178000 r-xp /usr/lib/libalarm.so.0.0.0
b417a000 b419b000 r-xp /usr/lib/libefl-extension.so.0.1.0
b419c000 b41a5000 r-xp /usr/lib/libappcore-watch.so.1.1
b41a6000 b41b1000 r-xp /lib/libnss_files-2.13.so
b43f2000 b4419000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b441a000 b443f000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4440000 b4561000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4571000 b45a7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b45a9000 b45ac000 r-xp /usr/lib/libiniparser.so.0
b45ae000 b45b8000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b45b9000 b45c2000 r-xp /usr/lib/libappsvc.so.0.1.0
b45c3000 b45c6000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b45c9000 b45cc000 r-xp /usr/lib/libdri2.so.0.0.0
b45cd000 b45cf000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45d0000 b45d4000 r-xp /opt/usr/apps/org.example.stemwatch/bin/stemwatch
b45d5000 b45db000 r-xp /usr/lib/libogg.so.0.7.1
b45dc000 b4607000 r-xp /usr/lib/libvorbis.so.0.4.3
b4608000 b46f3000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4701000 b4703000 r-xp /usr/lib/libXau.so.6.0.0
b4704000 b4764000 r-xp /usr/lib/libssl.so.1.0.0
b4769000 b479a000 r-xp /usr/lib/libidn.so.11.5.44
b479b000 b47ab000 r-xp /usr/lib/libcares.so.2.1.0
b47ac000 b4815000 r-xp /usr/lib/libsndfile.so.1.0.25
b481b000 b4825000 r-xp /usr/lib/libsensord-share.so
b4826000 b484c000 r-xp /lib/libexpat.so.1.5.2
b484e000 b4875000 r-xp /usr/lib/libpng12.so.0.50.0
b4876000 b4896000 r-xp /usr/lib/libxcb.so.1.1.0
b4897000 b4906000 r-xp /usr/lib/libcurl.so.4.3.0
b4908000 b4913000 r-xp /usr/lib/libethumb.so.1.7.99
b5e73000 b5f4b000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f57000 b5f5a000 r-xp /usr/lib/libctxdata.so.0.0.0
b5f5b000 b5f71000 r-xp /usr/lib/libremix.so.0.0.0
b5f72000 b5f74000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f75000 b5fa1000 r-xp /usr/lib/liblua-5.1.so
b5fa2000 b5fac000 r-xp /usr/lib/libembryo.so.1.7.99
b5fad000 b5ff3000 r-xp /usr/lib/libjpeg.so.8.0.2
b6004000 b6022000 r-xp /usr/lib/libsensor.so.1.1.0
b6024000 b60a6000 r-xp /usr/lib/libpixman-1.so.0.28.2
b60ab000 b60df000 r-xp /usr/lib/libfontconfig.so.1.5.0
b60e1000 b613c000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b613e000 b6154000 r-xp /usr/lib/libfribidi.so.0.3.1
b6155000 b61e1000 r-xp /usr/lib/libfreetype.so.6.11.3
b61e5000 b61e8000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b61e9000 b61ef000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b61f0000 b61f6000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61f8000 b6209000 r-xp /usr/lib/libXext.so.6.4.0
b620a000 b633e000 r-xp /usr/lib/libX11.so.6.3.0
b6342000 b6347000 r-xp /usr/lib/libXtst.so.6.1.0
b6348000 b6350000 r-xp /usr/lib/libXrender.so.1.3.0
b6351000 b635a000 r-xp /usr/lib/libXrandr.so.2.2.0
b635b000 b635d000 r-xp /usr/lib/libXinerama.so.1.0.0
b635e000 b636c000 r-xp /usr/lib/libXi.so.6.1.0
b636d000 b6371000 r-xp /usr/lib/libXfixes.so.3.1.0
b6372000 b6374000 r-xp /usr/lib/libXgesture.so.7.0.0
b6375000 b6377000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6378000 b637a000 r-xp /usr/lib/libXdamage.so.1.1.0
b637b000 b6384000 r-xp /usr/lib/libXcursor.so.1.0.2
b6385000 b63b0000 r-xp /usr/lib/libecore_con.so.1.7.99
b63b2000 b63ba000 r-xp /usr/lib/libecore_imf.so.1.7.99
b63bb000 b63c6000 r-xp /usr/lib/libethumb_client.so.1.7.99
b63c7000 b63cd000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b63ce000 b63ef000 r-xp /usr/lib/libefreet.so.1.7.99
b63f1000 b63fd000 r-xp /usr/lib/libedbus.so.1.7.99
b63fe000 b655d000 r-xp /usr/lib/libicuuc.so.51.1
b656b000 b6774000 r-xp /usr/lib/libicui18n.so.51.1
b677d000 b681a000 r-xp /usr/lib/libedje.so.1.7.99
b681c000 b682d000 r-xp /usr/lib/libecore_input.so.1.7.99
b682e000 b6835000 r-xp /usr/lib/libecore_file.so.1.7.99
b6836000 b685c000 r-xp /usr/lib/libeet.so.1.7.99
b6865000 b698d000 r-xp /usr/lib/libevas.so.1.7.99
b69aa000 b69dd000 r-xp /usr/lib/libecore_evas.so.1.7.99
b69df000 b6a23000 r-xp /usr/lib/libecore_x.so.1.7.99
b6a25000 b6c1f000 r-xp /usr/lib/libelementary.so.1.7.99
b6c30000 b6c36000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6c37000 b6c3b000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6c3f000 b6c40000 r-xp /usr/lib/libjournal.so.0.1.0
b6c41000 b6d89000 r-xp /usr/lib/libxml2.so.2.7.8
b6d90000 b6da3000 r-xp /lib/libresolv-2.13.so
b6da7000 b6dc4000 r-xp /lib/libz.so.1.2.5
b6dc5000 b6dc8000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6dc9000 b6dce000 r-xp /usr/lib/libffi.so.5.0.10
b6dcf000 b6dd0000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6dd2000 b6dd6000 r-xp /lib/libattr.so.1.1.0
b6dd7000 b6fe9000 r-xp /usr/lib/libcrypto.so.1.0.0
b7004000 b7025000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b7026000 b704e000 r-xp /lib/libm-2.13.so
b7050000 b70ab000 r-xp /usr/lib/libeina.so.1.7.99
b70ae000 b70b9000 r-xp /usr/lib/libvconf.so.0.2.45
b70ba000 b70bd000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b70be000 b710c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b710d000 b726e000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b7272000 b7279000 r-xp /lib/librt-2.13.so
b727c000 b7283000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b7285000 b729f000 r-xp /lib/libgcc_s-4.6.4.so.1
b72a0000 b72a8000 r-xp /lib/libcrypt-2.13.so
b72d1000 b72d5000 r-xp /lib/libcap.so.2.21
b72d6000 b72d8000 r-xp /usr/lib/libiri.so
b72da000 b7306000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b7307000 b7327000 r-xp /usr/lib/libecore.so.1.7.99
b7336000 b733f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b7340000 b7463000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b7464000 b7477000 r-xp /usr/lib/libail.so.0.1.0
b7479000 b749e000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b749f000 b74a9000 r-xp /lib/libunwind.so.8.0.1
b74b3000 b7624000 r-xp /lib/libc-2.13.so
b762a000 b7674000 r-xp /usr/lib/libdbus-1.so.3.7.2
b7675000 b767a000 r-xp /usr/lib/libbundle.so.0.1.22
b767b000 b767e000 r-xp /lib/libdl-2.13.so
b7681000 b7686000 r-xp /usr/lib/libsmack.so.1.0.0
b7687000 b772f000 r-xp /usr/lib/libsqlite3.so.0.8.6
b7732000 b774c000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b774d000 b7764000 r-xp /lib/libpthread-2.13.so
b7768000 b776b000 r-xp /usr/lib/libdlog.so.0.0.0
b776c000 b777c000 r-xp /usr/lib/libaul.so.0.1.0
b777e000 b7784000 r-xp /usr/lib/libappcore-common.so.1.1
b7785000 b778a000 r-xp /usr/lib/libappcore-efl.so.1.1
b778c000 b7791000 r-xp /usr/lib/libsys-assert.so
b7794000 b77b2000 r-xp /lib/ld-2.13.so
b77b2000 b77b3000 r-xp [vdso]
b77b5000 b77bc000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:4407)
Call Stack Count: 20
 0: eina_stringshare_add + 0x20 (0xb7080750) [/usr/lib/libeina.so.1] + 0x30750
 1: evas_object_smart_callback_priority_add + 0xbd (0xb68aa36d) [/usr/lib/libevas.so.1] + 0x4536d
 2: evas_object_smart_callback_add + 0x3a (0xb68aa48a) [/usr/lib/libevas.so.1] + 0x4548a
 3: create_popup + 0x11c (0xb45d295c) [/opt/usr/apps/org.example.stemwatch/bin/stemwatch] + 0x295c
 4: evas_object_smart_callback_call + 0xe2 (0xb68aa7d2) [/usr/lib/libevas.so.1] + 0x457d2
 5: (0xb6a8f446) [/usr/lib/libelementary.so.1] + 0x6a446
 6: (0xb67e79a0) [/usr/lib/libedje.so.1] + 0x6a9a0
 7: (0xb67eedd2) [/usr/lib/libedje.so.1] + 0x71dd2
 8: (0xb67e8a7c) [/usr/lib/libedje.so.1] + 0x6ba7c
 9: (0xb67e8faf) [/usr/lib/libedje.so.1] + 0x6bfaf
10: (0xb67e9164) [/usr/lib/libedje.so.1] + 0x6c164
11: (0xb7313f32) [/usr/lib/libecore.so.1] + 0xcf32
12: (0xb7310519) [/usr/lib/libecore.so.1] + 0x9519
13: (0xb731547a) [/usr/lib/libecore.so.1] + 0xe47a
14: ecore_main_loop_begin + 0x3f (0xb73159cf) [/usr/lib/libecore.so.1] + 0xe9cf
15: watch_core_main + 0x172 (0xb419fc72) [/usr/lib/libappcore-watch.so.1] + 0x3c72
16: watch_app_main + 0xd6 (0xb41a1686) [/usr/lib/libappcore-watch.so.1] + 0x5686
17: main + 0x115 (0xb45d1cd5) [/opt/usr/apps/org.example.stemwatch/bin/stemwatch] + 0x1cd5
18: (0xb77b85b1) [/opt/usr/apps/org.example.stemwatch/bin/stemwatch] + 0xb77b85b1
19: __libc_start_main + 0xf3 (0xb74cc0f3) [/lib/libc.so.6] + 0x190f3
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
( 4346): clock_view.c: _remove_formatters(621) > 
05-22 22:04:08.981+0900 D/DATA_PROVIDER_MASTER( 2289): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
05-22 22:04:08.981+0900 D/DATA_PROVIDER_MASTER( 2289): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
05-22 22:04:08.991+0900 D/DATA_PROVIDER_MASTER( 2289): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
05-22 22:04:08.991+0900 I/AUL_PAD ( 2204): sigchild.h: __launchpad_sig_child(142) > dead_pid = 4346 pgid = 4346
05-22 22:04:08.991+0900 I/AUL_PAD ( 2204): sigchild.h: __sigchild_action(123) > dead_pid(4346)
05-22 22:04:08.991+0900 D/AUL_PAD ( 2204): sigchild.h: __send_app_dead_signal(81) > send dead signal done
05-22 22:04:08.991+0900 I/AUL_PAD ( 2204): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
05-22 22:04:08.991+0900 I/AUL_PAD ( 2204): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
05-22 22:04:08.991+0900 D/W_HOME  ( 2263): main.c: _dead_cb(542) > PID(4346) is dead
05-22 22:04:08.991+0900 E/W_HOME  ( 2263): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
05-22 22:04:08.991+0900 D/STARTER ( 2250): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 4346)
05-22 22:04:08.991+0900 I/AUL_AMD ( 2167): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4346
05-22 22:04:08.991+0900 D/AUL_AMD ( 2167): amd_key.c: _unregister_key_event(161) > ===key stack===
05-22 22:04:08.991+0900 D/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-22 22:04:08.991+0900 E/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(264) > access
05-22 22:04:09.001+0900 D/DATA_PROVIDER_MASTER( 2289): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
05-22 22:04:09.031+0900 D/W_HOME  ( 2263): key.c: _key_release_cb(135) > Key(XF86Stop) released 1
05-22 22:04:09.031+0900 D/APPS    ( 2263): layout.c: _back_key_cb(68) >  Back key cb
05-22 22:04:09.031+0900 D/APPS    ( 2263): layout.c: _back_key_cb(78) >  apps status:[1]
05-22 22:04:09.031+0900 D/APPS    ( 2263): layout.c: apps_layout_show(476) >  (0xb92ba9b8) Hide the tray
05-22 22:04:09.031+0900 W/W_HOME  ( 2263): key.c: _execute_cbs(119) > back key execution has been stopped
05-22 22:04:09.111+0900 D/APP_CORE( 2263): appcore-efl.c: __hide_cb(848) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:1400007
05-22 22:04:09.111+0900 D/APP_CORE( 2263): appcore-efl.c: __hide_cb(855) >  Go to Pasue state 
05-22 22:04:09.111+0900 D/APP_CORE( 2263): appcore-efl.c: __do_app(470) > [APP 2263] Event: PAUSE State: RUNNING
05-22 22:04:09.111+0900 D/APP_CORE( 2263): appcore-efl.c: __do_app(538) > [APP 2263] PAUSE
05-22 22:04:09.111+0900 I/CAPI_APPFW_APPLICATION( 2263): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
05-22 22:04:09.111+0900 D/W_HOME  ( 2263): main.c: _pause_cb(600) > Paused
05-22 22:04:09.111+0900 E/W_HOME  ( 2263): main.c: _pause_cb(603) > paused already
05-22 22:04:09.111+0900 D/APP_CORE( 2263): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
05-22 22:04:09.111+0900 E/APP_CORE( 2263): appcore-efl.c: __trm_app_info_send_socket(233) > access
05-22 22:04:09.111+0900 E/W_HOME  ( 2263): main.c: _window_focus_out_cb(885) > win[20971523], ev->win[20971527]
05-22 22:04:09.111+0900 D/APPS    ( 2263): apps_main.c: _window_focus_out_cb(308) >  focus out
05-22 22:04:09.111+0900 E/W_HOME  ( 2263): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
05-22 22:04:09.111+0900 D/APPS    ( 2263): apps_main.c: apps_main_pause(656) >  Pause starts
05-22 22:04:09.111+0900 D/APPS    ( 2263): apps_main.c: apps_main_pause(676) >  Pause done
05-22 22:04:09.111+0900 D/W_HOME  ( 2263): index.c: index_update(405) > Index(0xb927cea8) is clear
05-22 22:04:09.111+0900 D/W_HOME  ( 2263): index.c: _update_left(230) > page:0xb93e09d0, total_inserted:0, idx_it:0xb93338f8
05-22 22:04:09.111+0900 D/W_HOME  ( 2263): index.c: _update_left(230) > page:0xb931f0c8, total_inserted:-1, idx_it:0xb9367328
05-22 22:04:09.111+0900 D/W_HOME  ( 2263): index.c: _update_left(264) > Index(0xb927cea8-0) is updating, page(0xb931f0c8-1:0)(start:0, mid:0, extra:0)
05-22 22:04:09.111+0900 D/W_HOME  ( 2263): index.c: _update_left(264) > Index(0xb927cea8-0) is updating, page(0xb93e09d0-2:1)(start:0, mid:0, extra:0)
05-22 22:04:09.111+0900 D/W_HOME  ( 2263): index.c: index_update(405) > Index(0xb92b88a8) is clear
05-22 22:04:09.111+0900 D/W_HOME  ( 2263): index.c: _update_right(352) > page:0xb931f0c8, total_inserted:2, idx_it:0xb9320748
05-22 22:04:09.111+0900 D/W_HOME  ( 2263): index.c: _update_right(352) > page:0xb93e09d0, total_inserted:2, idx_it:0xb92dc1d0
05-22 22:04:09.111+0900 D/W_HOME  ( 2263): index.c: _update_right(386) > Index(0xb92b88a8-2) is updating, page(0xb931f0c8-1:0)(start:0, mid:1, extra:0)
05-22 22:04:09.111+0900 D/W_HOME  ( 2263): index.c: _update_right(386) > Index(0xb92b88a8-2) is updating, page(0xb93e09d0-2:1)(start:0, mid:1, extra:0)
05-22 22:04:09.111+0900 D/W_HOME  ( 2263): scroller.c: _index_update_cb(992) > Index is updated
05-22 22:04:09.111+0900 E/EFL     ( 2263): edje<2263> edje_util.c:3592 edje_object_size_min_restricted_calc() group page_inner has a non-fixed part 'line,widget'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-22 22:04:09.111+0900 D/WIDGET_VIEWER( 2263): widget.c: widget_viewer_set_visibility(3860) > [SECURE_LOG] org.example.stemwatch has no changes
05-22 22:04:09.111+0900 E/EFL     ( 2263): edje<2263> edje_util.c:3592 edje_object_size_min_restricted_calc() group page_inner has a non-fixed part 'line,widget'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-22 22:04:09.111+0900 D/WIDGET_VIEWER( 2263): widget.c: widget_viewer_set_visibility(3860) > [SECURE_LOG] org.example.stemwatch has no changes
05-22 22:04:09.111+0900 D/WIDGET_VIEWER( 2263): widget.c: widget_viewer_set_visibility(3860) > [SECURE_LOG] org.example.stemwatch has no changes
05-22 22:04:09.111+0900 D/WIDGET_VIEWER( 2263): widget.c: widget_viewer_set_visibility(3860) > [SECURE_LOG] org.example.stemwatch has no changes
05-22 22:04:09.241+0900 D/W_HOME  ( 2263): main.c: _window_focus_in_cb(848) > focus in
05-22 22:04:09.241+0900 D/W_HOME  ( 2263): main.c: _resume_cb(564) > Resumed
05-22 22:04:09.241+0900 D/APPS    ( 2263): apps_main.c: apps_main_is_visible(757) >  bShow:[0]
05-22 22:04:09.241+0900 D/W_HOME  ( 2263): scroller.c: _resume_result_cb(623) > Activate the rotary events for Home
05-22 22:04:09.241+0900 E/efl-extension( 2263): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb923e860, elm_scroller, _activated_obj : 0xb936dfc0, activated : 1
05-22 22:04:09.241+0900 E/efl-extension( 2263): efl_extension_rotary.c: eext_rotary_object_event_activated_set(309) > Activation delete!!!!
05-22 22:04:09.241+0900 D/W_HOME  ( 2263): clock_inf_widget.c: home_resumed_cb(277) > Thaw all freezed objects
05-22 22:04:09.241+0900 W/W_HOME  ( 2263): main.c: _resume_cb(589) > clock/widget resumed
05-22 22:04:09.241+0900 D/W_HOME  ( 2263): clock_view.c: clock_view_event_handler(843) > event:10004 received
05-22 22:04:09.241+0900 D/W_HOME  ( 2263): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
05-22 22:04:09.241+0900 E/APPS    ( 2263): apps_main.c: _window_focus_in_cb(293) >  win[20971527], ev->win[20971523]
05-22 22:04:09.241+0900 W/W_HOME  ( 2263): main.c: _window_visibility_cb(796) > Window [0x1400003] is now visible(0)
05-22 22:04:09.241+0900 D/APP_CORE( 2263): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1400003 fully_obscured 0
05-22 22:04:09.241+0900 D/APP_CORE( 2263): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 0
05-22 22:04:09.241+0900 D/APP_CORE( 2263): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
05-22 22:04:09.241+0900 D/APP_CORE( 2263): appcore-efl.c: __do_app(470) > [APP 2263] Event: RESUME State: PAUSED
05-22 22:04:09.241+0900 D/LAUNCH  ( 2263): appcore-efl.c: __do_app(557) > [w-home:Application:resume:start]
05-22 22:04:09.241+0900 D/APP_CORE( 2263): appcore-efl.c: __do_app(559) > [APP 2263] RESUME
05-22 22:04:09.241+0900 I/CAPI_APPFW_APPLICATION( 2263): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
05-22 22:04:09.241+0900 D/W_HOME  ( 2263): main.c: _resume_cb(564) > Resumed
05-22 22:04:09.241+0900 E/W_HOME  ( 2263): main.c: _resume_cb(567) > resumed already
05-22 22:04:09.241+0900 D/LAUNCH  ( 2263): appcore-efl.c: __do_app(567) > [w-home:Application:resume:done]
05-22 22:04:09.241+0900 D/LAUNCH  ( 2263): appcore-efl.c: __do_app(569) > [w-home:Application:Launching:done]
05-22 22:04:09.241+0900 D/APP_CORE( 2263): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
05-22 22:04:09.241+0900 E/APP_CORE( 2263): appcore-efl.c: __trm_app_info_send_socket(233) > access
05-22 22:04:09.251+0900 D/DATA_PROVIDER_MASTER( 2289): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2263 is resumed
05-22 22:04:09.251+0900 D/DATA_PROVIDER_MASTER( 2289): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
05-22 22:04:09.251+0900 D/WATCH_CORE( 4407): appcore-watch.c: __widget_resume(922) > widget_resume
05-22 22:04:09.251+0900 D/WATCH_CORE( 4407): appcore-watch.c: __do_app(332) > WE_RESUME
05-22 22:04:09.251+0900 W/CAPI_WATCH_APPLICATION( 4407): watch_app_main.c: _watch_core_resume(262) > _watch_core_resume
05-22 22:04:09.251+0900 D/WATCH_CORE( 4407): appcore-watch.c: __watch_core_time_tick(834) > state: 2
05-22 22:04:09.251+0900 D/WATCH_CORE( 4407): appcore-watch.c: __watch_core_time_tick(845) > next time tick: 0.732000
05-22 22:04:09.251+0900 I/CAPI_WATCH_APPLICATION( 4407): watch_app_main.c: _watch_core_time_tick(301) > _watch_core_time_tick
05-22 22:04:09.991+0900 D/WATCH_CORE( 4407): appcore-watch.c: __watch_core_time_tick(834) > state: 2
05-22 22:04:09.991+0900 D/WATCH_CORE( 4407): appcore-watch.c: __watch_core_time_tick(845) > next time tick: 0.997000
05-22 22:04:09.991+0900 I/CAPI_WATCH_APPLICATION( 4407): watch_app_main.c: _watch_core_time_tick(301) > _watch_core_time_tick
05-22 22:04:10.071+0900 I/GESTURE ( 1991): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
05-22 22:04:10.111+0900 D/EFL     ( 2263): ecore_x<2263> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=1918095 button=1
05-22 22:04:10.111+0900 D/W_HOME  ( 2263): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
05-22 22:04:10.111+0900 D/W_HOME  ( 2263): dbus_util.c: home_dbus_scroll_booster_signal_send(296) > Sending scroll booster for 200 sec result:0
05-22 22:04:10.111+0900 D/W_HOME  ( 2263): layout.c: _gesture_down_cb(611) > Mouse is down on the gesture layer:244
05-22 22:04:10.111+0900 D/W_HOME  ( 2263): layout.c: _down_cb(250) > Mouse is down on the layout
05-22 22:04:10.111+0900 D/W_HOME  ( 2263): page.c: _down_cb(84) > Down (0xb931f0c8)(182, 244)
05-22 22:04:10.111+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: __widget_down_cb(1500) > [SECURE_LOG] Change to direct render
05-22 22:04:10.111+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: __widget_down_cb(1540) > [SECURE_LOG] 182.000000x244.000000 (1.000000x1.000000)
05-22 22:04:10.151+0900 D/WIDGET_PROVIDER( 4407): widget_provider_buffer.c: provider_buffer_widget_mouse_down(603) > [SECURE_LOG] Down: file:///opt/usr/share/live_magazine/org.example.stemwatch_2263_1914.420044.png
05-22 22:04:10.151+0900 E/WIDGET  ( 4407): virtual_window.c: processing_events(212) > [SECURE_LOG] DOWN[/opt/usr/share/live_magazine/org.example.stemwatch_2263_1914.420044.png] 182x244 - 1918128.540039 (0)
05-22 22:04:10.191+0900 D/EFL     ( 2263): ecore_x<2263> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=1918200 button=1
05-22 22:04:10.191+0900 D/W_HOME  ( 2263): layout.c: _up_cb(324) > Mouse is up on the layout
05-22 22:04:10.191+0900 D/W_HOME  ( 2263): page.c: _up_cb(115) > Up (0xb931f0c8)(182, 244)
05-22 22:04:10.191+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: __widget_up_cb(3047) > [SECURE_LOG] Change to render animator
05-22 22:04:10.191+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: __widget_up_cb(3177) > [SECURE_LOG] 182.000000x244.000000 (1.000000x1.000000)
05-22 22:04:10.191+0900 D/WIDGET_VIEWER( 2263): widget.c: widget_viewer_send_click_event(1876) > [SECURE_LOG] CLICKED: 1918.201294
05-22 22:04:10.191+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: __widget_up_cb(3199) > [SECURE_LOG] Up: 182.000000x244.000000 [x:0/1/0] [y:0/0/0], ret: 0x0, cancel: 0x0
05-22 22:04:10.201+0900 D/WIDGET_PROVIDER( 4407): widget_provider_buffer.c: provider_buffer_widget_mouse_up(639) > [SECURE_LOG] Up: file:///opt/usr/share/live_magazine/org.example.stemwatch_2263_1914.420044.png
05-22 22:04:10.201+0900 E/WIDGET  ( 4407): virtual_window.c: processing_events(248) > [SECURE_LOG] UP[/opt/usr/share/live_magazine/org.example.stemwatch_2263_1914.420044.png] 182x244 - 1918201.293945 (0)
05-22 22:04:10.261+0900 E/COM_CORE( 2289): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
05-22 22:04:10.261+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (51)
05-22 22:04:10.261+0900 D/COM_CORE( 2289): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
05-22 22:04:10.261+0900 D/COM_CORE( 2289): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
05-22 22:04:10.261+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
05-22 22:04:10.261+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
05-22 22:04:10.261+0900 E/DATA_PROVIDER_MASTER( 2289): fault_manager.c: check_log_file(90) > [SECURE_LOG] fopen [2]
05-22 22:04:10.261+0900 D/DATA_PROVIDER_MASTER( 2289): package.c: package_is_faulted(693) > [SECURE_LOG] Triggered fault_count, return 1
05-22 22:04:10.261+0900 E/DATA_PROVIDER_MASTER( 2289): fault_manager.c: clear_log_file(76) > [SECURE_LOG] unlink: 2
05-22 22:04:10.261+0900 D/DATA_PROVIDER_MASTER( 2289): slave_life.c: slave_deactivated_by_fault(1200) > [SECURE_LOG] Try to terminate PID: 4407
05-22 22:04:10.261+0900 D/AUL     ( 2289): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : 4407
05-22 22:04:10.261+0900 D/AUL     ( 2289): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(4)
05-22 22:04:10.261+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(495) > __request_handler: 4
05-22 22:04:10.261+0900 D/RESOURCED( 2369): proc-noti.c: recv_str(87) > [recv_str,87] str is null
05-22 22:04:10.261+0900 D/RESOURCED( 2369): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2167
05-22 22:04:10.261+0900 D/RESOURCED( 2369): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid (null), pid 4407, type 6 
05-22 22:04:10.261+0900 D/RESOURCED( 2369): proc-main.c: proc_remove_process_list(363) > [proc_remove_process_list,363] found_pid 4407
05-22 22:04:10.261+0900 D/AUL_AMD ( 2167): amd_request.c: __app_process_by_pid(179) > __app_process_by_pid, cmd: 4, pid: 4407, 
05-22 22:04:10.261+0900 D/AUL     ( 2167): app_sock.c: __app_send_raw_with_delay_reply(435) > pid(4407) : cmd(4)
05-22 22:04:10.261+0900 E/AUL     ( 2167): app_sock.c: __connect_client_sock(208) > connect error: 111
05-22 22:04:10.261+0900 E/AUL     ( 2167): app_sock.c: __create_client_sock(174) > cannot connect the client socket: 111
05-22 22:04:10.281+0900 I/AUL_PAD ( 2204): sigchild.h: __launchpad_sig_child(142) > dead_pid = 4407 pgid = 4407
05-22 22:04:10.281+0900 I/AUL_PAD ( 2204): sigchild.h: __sigchild_action(123) > dead_pid(4407)
05-22 22:04:10.281+0900 D/AUL_PAD ( 2204): sigchild.h: __send_app_dead_signal(81) > send dead signal done
05-22 22:04:10.281+0900 I/AUL_PAD ( 2204): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
05-22 22:04:10.281+0900 I/AUL_PAD ( 2204): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
05-22 22:04:10.291+0900 D/W_HOME  ( 2263): main.c: _dead_cb(542) > PID(4407) is dead
05-22 22:04:10.291+0900 E/W_HOME  ( 2263): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
05-22 22:04:10.291+0900 D/STARTER ( 2250): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 4407)
05-22 22:04:10.371+0900 E/AUL     ( 2167): app_sock.c: __connect_client_sock(208) > connect error: 111
05-22 22:04:10.371+0900 E/AUL     ( 2167): app_sock.c: __create_client_sock(174) > cannot connect the client socket: 111
05-22 22:04:10.681+0900 E/AUL     ( 2167): app_sock.c: __connect_client_sock(208) > connect error: 111
05-22 22:04:10.681+0900 E/AUL     ( 2167): app_sock.c: __create_client_sock(174) > cannot connect the client socket: 111
05-22 22:04:10.681+0900 D/AUL_AMD ( 2167): amd_launch.c: _term_app(883) > terminate packet send error - use SIGKILL
05-22 22:04:10.681+0900 E/AUL_AMD ( 2167): amd_launch.c: _term_app(885) > fail to killing - 4407
05-22 22:04:10.681+0900 I/AUL_AMD ( 2167): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4407
05-22 22:04:10.681+0900 D/AUL_AMD ( 2167): amd_key.c: _unregister_key_event(161) > ===key stack===
05-22 22:04:10.681+0900 D/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-22 22:04:10.681+0900 E/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(264) > access
05-22 22:04:10.681+0900 D/AUL     ( 2289): launch.c: app_request_to_launchpad(295) > launch request result : -1
05-22 22:04:10.681+0900 E/DATA_PROVIDER_MASTER( 2289): slave_life.c: slave_deactivated_by_fault(1203) > [SECURE_LOG] Terminate failed, pid 4407
05-22 22:04:10.681+0900 D/DATA_PROVIDER_MASTER( 2289): instance.c: instance_destroyed(3314) > [SECURE_LOG] Send deleted event - multicast
05-22 22:04:10.681+0900 D/DATA_PROVIDER_MASTER( 2289): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
05-22 22:04:10.681+0900 E/DATA_PROVIDER_MASTER( 2289): instance.c: send_gbar_destroyed_to_client(660) > [SECURE_LOG] GBAR is not created
05-22 22:04:10.681+0900 D/DATA_PROVIDER_MASTER( 2289): instance.c: destroy_instance(791) > [SECURE_LOG] Instance is destroyed (0xb8f7c690), slave(0xb8f62c08)
05-22 22:04:10.681+0900 E/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: buffer_handler_unload(700) > [SECURE_LOG] Buffer is not loaded
05-22 22:04:10.681+0900 E/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: buffer_handler_unload(700) > [SECURE_LOG] Buffer is not loaded
05-22 22:04:10.681+0900 D/DATA_PROVIDER_MASTER( 2289): slave_life.c: slave_unload_instance(1705) > [SECURE_LOG] Instance: (-1)0
05-22 22:04:10.681+0900 D/DATA_PROVIDER_MASTER( 2289): slave_rpc.c: slave_deactivate_cb(338) > [SECURE_LOG] Reset handle for -1 (51)
05-22 22:04:10.681+0900 D/DATA_PROVIDER_MASTER( 2289): dead_monitor.c: evt_cb(98) > [SECURE_LOG] Slave is deleted
05-22 22:04:10.681+0900 D/COM_CORE( 2289): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(51) for pid(-1)
05-22 22:04:10.681+0900 E/COM_CORE( 2289): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
05-22 22:04:10.681+0900 D/WIDGET_VIEWER( 2263): client.c: master_fault_package(85) > [SECURE_LOG] [org.example.stemwatch]
05-22 22:04:10.681+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: widget_fault_handler(6669) > [SECURE_LOG] Faulted: org.example.stemwatch (0xb9306600)
05-22 22:04:10.681+0900 E/WIDGET_SERVICE( 2263): widget_service.c: widget_service_get_preview_image_path(1854) > [SECURE_LOG] Failed to get data (org.example.stemwatch)
05-22 22:04:10.681+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: __widget_overlay_faulted(5354) > [SECURE_LOG] Set overlay fault (0xb9306600) org.example.stemwatch
05-22 22:04:10.681+0900 D/WIDGET_VIEWER( 2263): client.c: master_deleted(201) > [SECURE_LOG] [org.example.stemwatch]
05-22 22:04:10.681+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: __widget_event_deleted(6142) > [SECURE_LOG] widget is deleted: 0xb9306600 (emit signal)
05-22 22:04:10.681+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: __widget_event_deleted(6155) > [SECURE_LOG] Invoke raw delete org.example.stemwatch
05-22 22:04:10.681+0900 D/W_HOME  ( 2263): clock_inf_widget.c: user_del_cb(219) > Faulted: org.example.stemwatch, Current: org.example.stemwatch
05-22 22:04:10.681+0900 D/W_HOME  ( 2263): clock_inf_widget.c: user_del_cb(234) > There is no waiting clock. Try to recover from fault (19)
05-22 22:04:10.681+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: widget_unref(956) > [SECURE_LOG] refcnt: 1 (org.example.stemwatch)
05-22 22:04:10.681+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: __widget_overlay_clicked_cb(3500) > [SECURE_LOG] Overlay is clicked: (mouse,clicked,1) (overlay,content)
05-22 22:04:10.681+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: __widget_overlay_clicked_cb(3508) > [SECURE_LOG] Activate: [org.example.stemwatch]
05-22 22:04:10.691+0900 D/WIDGET_VIEWER( 2263): widget_internal.c: _widget_unref(763) > [SECURE_LOG] Handler is released
05-22 22:04:10.691+0900 E/DATA_PROVIDER_MASTER( 2289): server.c: validate_request(1030) > [SECURE_LOG] Instance is not exists (file:///opt/usr/share/live_magazine/org.example.stemwatch_2263_1914.420044.png)
05-22 22:04:10.691+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: client_widget_release_pixmap(5392) > [SECURE_LOG] It seems that the instance is already deleted: file:///opt/usr/share/live_magazine/org.example.stemwatch_2263_1914.420044.png
05-22 22:04:10.691+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: destroy_pixmap(343) > [SECURE_LOG] pixmap 12582972
05-22 22:04:10.721+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: client_activate_package(6304) > [SECURE_LOG] pid[2263] pkgname[org.example.stemwatch]
05-22 22:04:10.791+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: activate_ret_cb(3420) > [SECURE_LOG] Activated (org.example.stemwatch): 0
05-22 22:04:10.791+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: activate_ret_cb(3450) > [SECURE_LOG] Added Handle: (0xb9328238) 0xb9306600
05-22 22:04:10.791+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: __widget_overlay_loading(5252) > [SECURE_LOG] Loading overlay is disabled
05-22 22:04:10.791+0900 D/WIDGET_EVAS( 2263): widget_viewer_evas.c: widget_unref(956) > [SECURE_LOG] refcnt: 2 (org.example.stemwatch)
05-22 22:04:10.811+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: client_new(1409) > [SECURE_LOG] pid[2263] period[1918.797729] pkgname[org.example.stemwatch] content[] cluster[user,created] category[default] period[-1.000000]
05-22 22:04:10.821+0900 D/DATA_PROVIDER_MASTER( 2289): util.c: util_free_space(163) > [SECURE_LOG] Available size: 4452130816, f_bsize: 4096, f_bavail: 1086946
05-22 22:04:10.821+0900 D/DATA_PROVIDER_MASTER( 2289): package.c: assign_new_slave(1172) > [SECURE_LOG] New slave[8_1918.837422] is assigned for org.example.stemwatch (using org.example.stemwatch / abi[app] / accel[use-sw]
05-22 22:04:10.821+0900 D/DATA_PROVIDER_MASTER( 2289): slave_life.c: slave_load_instance(1684) > [SECURE_LOG] Instance: (-1)1
05-22 22:04:10.821+0900 E/DATA_PROVIDER_MASTER( 2289): slave_life.c: slave_activate(892) > [SECURE_LOG] Launch App [org.example.stemwatch]
05-22 22:04:10.821+0900 D/AUL     ( 2289): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.example.stemwatch
05-22 22:04:10.821+0900 D/AUL     ( 2289): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
05-22 22:04:10.821+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(495) > __request_handler: 0
05-22 22:04:10.821+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(540) > launch a single-instance appid: org.example.stemwatch
05-22 22:04:10.831+0900 D/AUL     ( 2167): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2289, pid = 2289
05-22 22:04:10.831+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
05-22 22:04:10.831+0900 E/AUL_AMD ( 2167): amd_launch.c: invoke_dbus_method_sync(1190) > dbus_connection_send error(org.freedesktop.DBus.Error.ServiceUnknown:The name org.tizen.system.coord was not provided by any .service files)
05-22 22:04:10.831+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1690) > org.tizen.system.coord.rotation-Degree : -74
05-22 22:04:10.831+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1785) > process_pool: false
05-22 22:04:10.831+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
05-22 22:04:10.831+0900 D/AUL_AMD ( 2167): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.example.stemwatch
05-22 22:04:10.831+0900 D/AUL_AMD ( 2167): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-22 22:04:10.831+0900 D/AUL     ( 2167): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
05-22 22:04:10.831+0900 D/AUL_PAD ( 2204): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.stemwatch
05-22 22:04:10.831+0900 D/AUL_PAD ( 2204): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
05-22 22:04:10.831+0900 D/AUL_PAD ( 2204): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 4416 /opt/usr/apps/org.example.stemwatch/bin/stemwatch
05-22 22:04:10.831+0900 D/AUL_PAD ( 2204): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
05-22 22:04:10.841+0900 D/AUL_PAD ( 4416): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
05-22 22:04:10.841+0900 D/AUL_PAD ( 4416): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
05-22 22:04:10.841+0900 D/AUL_PAD ( 4416): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.stemwatch / pkg_type : rpm / app_path : /opt/usr/apps/org.example.stemwatch/bin/stemwatch 
05-22 22:04:10.851+0900 D/AUL_PAD ( 4416): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
05-22 22:04:10.851+0900 D/AUL_PAD ( 4416): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.stemwatch/bin/stemwatch##
05-22 22:04:10.851+0900 D/AUL_PAD ( 4416): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __APP_SVC_OP_TYPE__##
05-22 22:04:10.851+0900 D/AUL_PAD ( 4416): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : name##
05-22 22:04:10.851+0900 D/AUL_PAD ( 4416): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : secured##
05-22 22:04:10.851+0900 D/AUL_PAD ( 4416): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : abi##
05-22 22:04:10.851+0900 D/AUL_PAD ( 4416): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : hw-acceleration##
05-22 22:04:10.851+0900 D/AUL_PAD ( 4416): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 12 : __AUL_STARTTIME__##
05-22 22:04:10.861+0900 D/AUL_PAD ( 4416): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 14 : __AUL_CALLER_PID__##
05-22 22:04:10.861+0900 D/LAUNCH  ( 4416): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.stemwatch/bin/stemwatch:Platform:launchpad:done]
05-22 22:04:10.891+0900 I/efl-extension( 4416): efl_extension.c: eext_mod_init(39) > Init
05-22 22:04:10.941+0900 D/AUL_PAD ( 2204): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
05-22 22:04:10.941+0900 D/AUL_PAD ( 2204): sigchild.h: __send_app_launch_signal(112) > send launch signal done
05-22 22:04:10.941+0900 D/AUL_PAD ( 2204): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
05-22 22:04:10.941+0900 D/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-22 22:04:10.941+0900 E/AUL     ( 2167): simple_util.c: __trm_app_info_send_socket(264) > access
05-22 22:04:10.941+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(495) > __request_handler: 31
05-22 22:04:10.941+0900 E/AUL_AMD ( 2167): amd_status.c: _status_get_cmdline(554) > cmdline : /opt/usr/apps/org.example.stemwatch/bin/stemwatch
05-22 22:04:10.941+0900 E/AUL_AMD ( 2167): amd_status.c: _status_get_cmdline(557) > pkt->data : /opt/usr/apps/org.example.stemwatch/bin/stemwatch
05-22 22:04:10.941+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(740) > APP_GET_CMDLINE : 4416 : 0
05-22 22:04:10.941+0900 D/RESOURCED( 2369): proc-noti.c: recv_str(87) > [recv_str,87] str is null
05-22 22:04:10.941+0900 D/RESOURCED( 2369): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2167
05-22 22:04:10.941+0900 D/RESOURCED( 2369): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.stemwatch, pid 4416, type 4 
05-22 22:04:10.941+0900 D/RESOURCED( 2369): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.stemwatch, 4416
05-22 22:04:10.941+0900 D/RESOURCED( 2369): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.stemwatch with pkgname
05-22 22:04:10.941+0900 E/RESOURCED( 2369): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 375
05-22 22:04:10.941+0900 D/RESOURCED( 2369): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
05-22 22:04:10.941+0900 D/AUL     ( 2289): launch.c: app_request_to_launchpad(295) > launch request result : 4416
05-22 22:04:10.941+0900 D/DATA_PROVIDER_MASTER( 2289): slave_life.c: slave_activate(925) > [SECURE_LOG] Slave org.example.stemwatch is launched with 4416 as 8_1918.837422
05-22 22:04:10.941+0900 D/DATA_PROVIDER_MASTER( 2289): slave_rpc.c: slave_rpc_async_request(416) > [SECURE_LOG] RPC handle is not ready to use it
05-22 22:04:10.941+0900 D/AUL     ( 4416): app_sock.c: __app_send_cmd_with_result(618) > recv result  = 58
05-22 22:04:10.941+0900 D/AUL     ( 4416): pkginfo.c: aul_app_get_cmdline_bypid(308) > cmdline : /opt/usr/apps/org.example.stemwatch/bin/stemwatch
05-22 22:04:10.941+0900 D/AUL     ( 4416): app_sock.c: __create_server_sock(136) > pg path - already exists
05-22 22:04:10.941+0900 D/WATCH_CORE( 4416): appcore-watch.c: __watch_core_widget_init(1003) > Initialize the widget
05-22 22:04:10.941+0900 D/WIDGET_SERVICE( 4416): widget_conf.c: conf_path(1069) > [SECURE_LOG] Selected conf file: /usr/share/data-provider-master/360x360/conf.ini
05-22 22:04:10.941+0900 D/WIDGET_SERVICE( 4416): widget_conf.c: minimum_period_handler(445) > [SECURE_LOG] Minimum period: 1.000000
05-22 22:04:10.941+0900 D/WIDGET_SERVICE( 4416): widget_conf.c: default_period_handler(485) > [SECURE_LOG] Default Period: -1.000000
05-22 22:04:10.941+0900 D/WIDGET_SERVICE( 4416): widget_conf.c: default_packet_time_handler(493) > [SECURE_LOG] Default packet time: 0.000100
05-22 22:04:10.941+0900 D/WIDGET_SERVICE( 4416): widget_conf.c: slave_ttl_handler(532) > [SECURE_LOG] Slave TTL: 0.000000
05-22 22:04:10.941+0900 D/WIDGET_SERVICE( 4416): widget_conf.c: slave_activate_time_handler(540) > [SECURE_LOG] Slave activate time: 30.000000
05-22 22:04:10.941+0900 D/WIDGET_SERVICE( 4416): widget_conf.c: slave_relaunch_time_handler(556) > [SECURE_LOG] Slave relaunch time: 3.000000
05-22 22:04:10.941+0900 D/WIDGET_SERVICE( 4416): widget_conf.c: ping_time_handler(943) > [SECURE_LOG] Default ping time: 240.000000
05-22 22:04:10.941+0900 D/WIDGET_SERVICE( 4416): widget_conf.c: input_path_handler(916) > [SECURE_LOG] Specifying the input device [0]
05-22 22:04:10.941+0900 D/WIDGET_SERVICE( 4416): widget_conf.c: premultiplied_handler(959) > [SECURE_LOG] Premultiplied: 0
05-22 22:04:10.961+0900 D/WIDGET_PROVIDER_APP( 4416): client.c: is_watchapp(1227) > [SECURE_LOG] component type: watchapp
05-22 22:04:10.961+0900 D/WIDGET_PROVIDER_APP( 4416): client.c: is_watchapp(1230) > [SECURE_LOG] this app is watch app
05-22 22:04:10.961+0900 D/WIDGET_PROVIDER_APP( 4416): client.c: client_init_sync(1336) > [SECURE_LOG] Name assigned: 4416.1918.965778 (app)
05-22 22:04:10.961+0900 D/WIDGET_PROVIDER_APP( 4416): client.c: client_init_sync(1337) > [SECURE_LOG] Secured: true
05-22 22:04:10.961+0900 D/WIDGET_PROVIDER_APP( 4416): client.c: client_init_sync(1338) > [SECURE_LOG] hw-acceleration: use-sw
05-22 22:04:10.961+0900 D/COM_CORE( 2289): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [51] New TCB created: R(52), W(53)
05-22 22:04:10.961+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 51 (server: 4)
05-22 22:04:10.961+0900 D/COM_CORE( 4416): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [17] New TCB created: R(18), W(19)
05-22 22:04:10.961+0900 D/WIDGET_SERVICE( 4416): util_x11.c: widget_util_get_drm_fd(401) > [SECURE_LOG] DRM Magic: 0x25
05-22 22:04:10.961+0900 D/WIDGET_PROVIDER( 4416): widget_provider.c: connected_cb(1199) > [SECURE_LOG] Connected (0xb415bde0) 17
05-22 22:04:10.961+0900 D/WIDGET_PROVIDER( 4416): widget_provider.c: widget_provider_send_hello_sync(1524) > [SECURE_LOG] name[4416.1918.965778]
05-22 22:04:10.961+0900 D/WIDGET_PROVIDER( 4416): widget_provider.c: widget_provider_send_hello_sync(1538) > [SECURE_LOG] Accel[use-sw], abi[app]
05-22 22:04:10.961+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(495) > __request_handler: 15
05-22 22:04:10.961+0900 D/AUL_AMD ( 2167): amd_status.c: _status_get_appid_bypid(432) > [SECURE_LOG] appid for 4416 is org.example.stemwatch
05-22 22:04:10.961+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(671) > APP_GET_APPID_BYPID : 4416 : 0
05-22 22:04:10.961+0900 D/AUL_AMD ( 2167): amd_status.c: __app_terminate_timer_cb(113) > pid(4346)
05-22 22:04:10.961+0900 D/AUL_AMD ( 2167): amd_status.c: __app_terminate_timer_cb(117) > send SIGKILL: No such process
05-22 22:04:10.961+0900 D/AUL     ( 2289): app_sock.c: __app_send_cmd_with_result(618) > recv result  = 30
05-22 22:04:10.961+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: slave_hello_sync_prepare(8191) > [SECURE_LOG] Sync context created: org.example.stemwatch (4416)
05-22 22:04:10.971+0900 D/COM_CORE( 2289): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [56] New TCB created: R(57), W(58)
05-22 22:04:10.971+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 56 (server: 4)
05-22 22:04:10.971+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: slave_hello_sync(8248) > [SECURE_LOG] New slave[4416.1918.965778](4416) is arrived.
05-22 22:04:10.971+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(495) > __request_handler: 15
05-22 22:04:10.971+0900 D/AUL_AMD ( 2167): amd_status.c: _status_get_appid_bypid(432) > [SECURE_LOG] appid for 4416 is org.example.stemwatch
05-22 22:04:10.971+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(671) > APP_GET_APPID_BYPID : 4416 : 0
05-22 22:04:10.971+0900 D/AUL     ( 2289): app_sock.c: __app_send_cmd_with_result(618) > recv result  = 30
05-22 22:04:10.971+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: slave_hello_sync(8352) > [SECURE_LOG] Hello sync context found: org.example.stemwatch
05-22 22:04:10.971+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(495) > __request_handler: 15
05-22 22:04:10.981+0900 D/AUL_AMD ( 2167): amd_status.c: _status_get_appid_bypid(432) > [SECURE_LOG] appid for 4416 is org.example.stemwatch
05-22 22:04:10.981+0900 D/AUL_AMD ( 2167): amd_request.c: __request_handler(671) > APP_GET_APPID_BYPID : 4416 : 0
05-22 22:04:10.981+0900 D/AUL     ( 2289): app_sock.c: __app_send_cmd_with_result(618) > recv result  = 30
05-22 22:04:10.981+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: slave_hello_sync(8418) > [SECURE_LOG] [org.example.stemwatch] Instance Count: 1
05-22 22:04:10.981+0900 D/DATA_PROVIDER_MASTER( 2289): slave_life.c: slave_set_valid(2155) > [SECURE_LOG] slave is set valid
05-22 22:04:10.981+0900 D/DATA_PROVIDER_MASTER( 2289): slave_rpc.c: slave_rpc_update_handle(518) > [SECURE_LOG] SLAVE: New handle assigned for 4416, 51
05-22 22:04:10.981+0900 D/DATA_PROVIDER_MASTER( 2289): package.c: slave_activated_cb(154) > [SECURE_LOG] Do not need to reactivate instances
05-22 22:04:10.981+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: slave_hello_sync(8448) > [SECURE_LOG] Slave is activated by request: 4416 (org.example.stemwatch)/(4416.1918.965778)
05-22 22:04:10.981+0900 D/DATA_PROVIDER_MASTER( 2289): instance.c: instance_watch_change_package_info(4000) > [SECURE_LOG] Package information is not touched (org.example.stemwatch)
05-22 22:04:10.981+0900 D/DATA_PROVIDER_MASTER( 2289): instance.c: instance_duplicate_packet_create(1109) > [SECURE_LOG] [TODO] Instance package info: 0xb8f5f210:org.example.stemwatch
05-22 22:04:10.981+0900 D/DATA_PROVIDER_MASTER( 2289): instance.c: instance_duplicate_packet_create(1137) > [SECURE_LOG] [TODO] Instance request_state is not touched
05-22 22:04:10.981+0900 D/DATA_PROVIDER_MASTER( 2289): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
05-22 22:04:10.981+0900 D/COM_CORE( 4416): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2289, fd: -1
05-22 22:04:10.981+0900 D/COM_CORE( 4416): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 165 bytes (pid: 2289), fd: -1
05-22 22:04:10.981+0900 D/COM_CORE( 4416): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
05-22 22:04:10.981+0900 D/WIDGET_PROVIDER_APP( 4416): client.c: method_new(475) > [SECURE_LOG] Create: pkgname[org.example.stemwatch], id[file:///opt/usr/share/live_magazine/org.example.stemwatch_2263_1918.797729.png], content[], timeout[10], has_script[0], period[0.000000], cluster[user,created], category[default], skip[1], abi[app], size: 360x360, ori: 0
05-22 22:04:10.981+0900 D/WATCH_CORE( 4416): appcore-watch.c: __widget_create(870) > widget_create
05-22 22:04:10.981+0900 W/CAPI_WATCH_APPLICATION( 4416): watch_app_main.c: _watch_core_create(205) > _watch_core_create
05-22 22:04:10.981+0900 D/WIDGET  ( 4416): binder.c: load_ecore_evas_function(98) > [SECURE_LOG] pixmap_allocfunc_new is not found
05-22 22:04:10.981+0900 D/WIDGET  ( 4416): binder.c: load_ecore_evas_function(103) > [SECURE_LOG] allocfunc_with_stirde_new is not found
05-22 22:04:10.991+0900 D/WIDGET_PROVIDER( 4416): widget_provider_buffer.c: widget_provider_buffer_create(2015) > [SECURE_LOG] acquire_buffer: [WIDGET] file:///opt/usr/share/live_magazine/org.example.stemwatch_2263_1918.797729.png, handler: 0xb414f4d0
05-22 22:04:10.991+0900 D/WIDGET  ( 4416): binder.c: binder_ecore_evas_new(522) > [SECURE_LOG] Preferred engine: (null) (opengl or opengl_x11)
05-22 22:04:10.991+0900 D/WIDGET_PROVIDER( 4416): widget_provider_buffer.c: widget_provider_buffer_acquire(2087) > [SECURE_LOG] acquire_buffer: [WIDGET] file:///opt/usr/share/live_magazine/org.example.stemwatch_2263_1918.797729.png, 1x1, size: 4, handler: 0xb414f4d0
05-22 22:04:10.991+0900 D/COM_CORE( 2289): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [61] New TCB created: R(62), W(63)
05-22 22:04:10.991+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 61 (server: 4)
05-22 22:04:10.991+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: buffer_handler_resize(1047) > [SECURE_LOG] Buffer size is updated[1x1]
05-22 22:04:10.991+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: load_pixmap_buffer(539) > [SECURE_LOG] Loaded pixmap(info->id): pixmap://12582974:4
05-22 22:04:11.001+0900 D/COM_CORE( 4416): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2289, fd: -1
05-22 22:04:11.001+0900 D/COM_CORE( 4416): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 24 bytes (pid: 2289), fd: -1
05-22 22:04:11.001+0900 D/COM_CORE( 4416): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
05-22 22:04:11.001+0900 D/WIDGET_PROVIDER( 4416): fb.c: fb_create(610) > [SECURE_LOG] PIXMAP: 12582974
05-22 22:04:11.001+0900 D/WIDGET_PROVIDER( 4416): widget_provider_buffer.c: send_acquire_request(148) > [SECURE_LOG] type: 0x0, name: 4416.1918.965778, pkgname[org.example.stemwatch], id[file:///opt/usr/share/live_magazine/org.example.stemwatch_2263_1918.797729.png], w[1], h[1], size[4], buffer_id[pixmap://12582974:4], fb[0xb90b6cd8]
05-22 22:04:11.001+0900 D/WIDGET_PROVIDER( 4416): fb.c: create_gem(509) > [SECURE_LOG] dri2_buffer: 0xb9111e38, name: 0xd, 1x1 (1x1), pitch: 4, buf_count: 1, gem: 0xb90b6e28
05-22 22:04:11.001+0900 D/WIDGET  ( 4416): binder.c: alloc_fb(430) > [SECURE_LOG] HW Accelerated buffer is created 0xb9111ee0, (1x1)
05-22 22:04:11.001+0900 E/COM_CORE( 2289): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (56)
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(56) for pid(-1)
05-22 22:04:11.001+0900 E/COM_CORE( 2289): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
05-22 22:04:11.001+0900 D/COM_CORE( 4416): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 17 (server: -1)
05-22 22:04:11.001+0900 E/COM_CORE( 2289): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (61)
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(61) for pid(-1)
05-22 22:04:11.001+0900 E/COM_CORE( 2289): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
05-22 22:04:11.001+0900 D/WIDGET  ( 4416): binder.c: load_update_function(128) > [SECURE_LOG] App detected
05-22 22:04:11.001+0900 D/WIDGET_PROVIDER( 4416): fb.c: destroy_gem(524) > [SECURE_LOG] unref pixmap bo
05-22 22:04:11.001+0900 D/WIDGET  ( 4416): binder.c: free_fb(481) > [SECURE_LOG] HW Accelerated buffer is destroyed
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [56] New TCB created: R(57), W(58)
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 56 (server: 4)
05-22 22:04:11.001+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: destroy_pixmap(343) > [SECURE_LOG] pixmap 12582974
05-22 22:04:11.001+0900 D/COM_CORE( 4416): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2289, fd: -1
05-22 22:04:11.001+0900 D/COM_CORE( 4416): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2289), fd: -1
05-22 22:04:11.001+0900 D/COM_CORE( 4416): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
05-22 22:04:11.001+0900 D/WIDGET  ( 4416): widget.c: widget_viewer_release_buffer(609) > [SECURE_LOG] Release buffer: -1 (0)
05-22 22:04:11.001+0900 D/WIDGET  ( 4416): binder.c: alloc_fb(409) > [SECURE_LOG] Size of ee is updated: 360x360 (info: 0xb9111ee0)
05-22 22:04:11.001+0900 D/WIDGET_PROVIDER( 4416): widget_provider_buffer.c: widget_provider_buffer_acquire(2087) > [SECURE_LOG] acquire_buffer: [WIDGET] file:///opt/usr/share/live_magazine/org.example.stemwatch_2263_1918.797729.png, 360x360, size: 4, handler: 0xb414f4d0
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [61] New TCB created: R(62), W(63)
05-22 22:04:11.001+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 61 (server: 4)
05-22 22:04:11.001+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: buffer_handler_resize(1047) > [SECURE_LOG] Buffer size is updated[360x360]
05-22 22:04:11.011+0900 E/COM_CORE( 2289): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
05-22 22:04:11.011+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (56)
05-22 22:04:11.031+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: load_pixmap_buffer(539) > [SECURE_LOG] Loaded pixmap(info->id): pixmap://12582976:4
05-22 22:04:11.031+0900 D/COM_CORE( 2289): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
05-22 22:04:11.031+0900 D/COM_CORE( 2289): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
05-22 22:04:11.031+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
05-22 22:04:11.031+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
05-22 22:04:11.031+0900 D/COM_CORE( 2289): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(56) for pid(-1)
05-22 22:04:11.031+0900 E/COM_CORE( 2289): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
05-22 22:04:11.031+0900 D/COM_CORE( 4416): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2289, fd: -1
05-22 22:04:11.031+0900 D/COM_CORE( 4416): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 24 bytes (pid: 2289), fd: -1
05-22 22:04:11.031+0900 D/COM_CORE( 4416): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
05-22 22:04:11.031+0900 D/WIDGET_PROVIDER( 4416): fb.c: fb_create(610) > [SECURE_LOG] PIXMAP: 12582976
05-22 22:04:11.031+0900 D/WIDGET_PROVIDER( 4416): widget_provider_buffer.c: send_acquire_request(148) > [SECURE_LOG] type: 0x0, name: 4416.1918.965778, pkgname[org.example.stemwatch], id[file:///opt/usr/share/live_magazine/org.example.stemwatch_2263_1918.797729.png], w[360], h[360], size[4], buffer_id[pixmap://12582976:4], fb[0xb9139650]
05-22 22:04:11.031+0900 E/COM_CORE( 2289): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
05-22 22:04:11.031+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (61)
05-22 22:04:11.031+0900 D/COM_CORE( 2289): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
05-22 22:04:11.031+0900 D/COM_CORE( 2289): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
05-22 22:04:11.031+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
05-22 22:04:11.031+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
05-22 22:04:11.031+0900 D/COM_CORE( 2289): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(61) for pid(-1)
05-22 22:04:11.031+0900 E/COM_CORE( 2289): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
05-22 22:04:11.031+0900 D/WIDGET_PROVIDER( 4416): fb.c: create_gem(509) > [SECURE_LOG] dri2_buffer: 0xb91396a0, name: 0xd, 360x360 (360x360), pitch: 1440, buf_count: 1, gem: 0xb90b6e28
05-22 22:04:11.031+0900 D/WIDGET  ( 4416): binder.c: alloc_fb(430) > [SECURE_LOG] HW Accelerated buffer is created 0xb9111ee0, (360x360)
05-22 22:04:11.051+0900 D/WIDGET_VIEWER( 2263): client.c: master_update_id(1650) > [SECURE_LOG] Update ID(file:///opt/usr/share/live_magazine/org.example.stemwatch_2263_1918.797729.png) for 1918.797729
05-22 22:04:11.101+0900 W/CRASH_MANAGER( 4424): worker.c: worker_job(1189) > 1104407737465146392225
