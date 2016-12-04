S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:37

Crash Information
Process Name: stemwatch
PID: 4441
Date: 2016-05-22 03:25:12+0900
Executable File Path: /opt/usr/apps/org.example.stemwatch/bin/stemwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x1

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xb45fe448, esi = 0x00000001
ebp = 0xbfb1afc8, esp = 0xbfb1af40
eax = 0x00000001, ebx = 0xb764fff4
ecx = 0x00000000, edx = 0x00000001
eip = 0xb7551fef

Memory Information
MemTotal:      124 KB
MemFree:        40 KB
Buffers:         4 KB
Cached:     215972 KB
VmPeak:      89348 KB
VmSize:      89348 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16644 KB
VmRSS:       16644 KB
VmData:      29188 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32156 KB
VmPTE:          84 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 4441 TID = 4441
4441 4443 4454 

Maps Information
b2447000 b2448000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b2449000 b244a000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b244b000 b2453000 r-xp /usr/lib/libfeedback.so.0.1.4
b245f000 b2460000 r-xp /usr/lib/edje/modules/feedback/linux-gnu-i686-1.0.0/module.so
b350e000 b3510000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnu-i686-1.7.99/module.so
b3511000 b3535000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b3756000 b3764000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b3765000 b3768000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnu-i686-1.7.99/module.so
b3769000 b376c000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b3f71000 b3f74000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3f75000 b3f7e000 r-xp /usr/lib/libtbm.so.1.0.0
b3f7f000 b3f85000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3f86000 b3f91000 r-xp /usr/lib/libdrm.so.2.4.0
b3f92000 b3fc4000 r-xp /usr/lib/libsystemd.so.0.0.1
b3fc7000 b3fcf000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3fd0000 b3fea000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b3feb000 b400b000 r-xp /usr/lib/libwidget_service.so.1.0.0
b400c000 b4028000 r-xp /usr/lib/libcom-core.so.0.0.1
b4029000 b416d000 r-xp /usr/lib/libcairo.so.2.11200.14
b4171000 b4180000 r-xp /usr/lib/libwidget.so.1.0.0
b4181000 b418d000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b418e000 b41a1000 r-xp /usr/lib/libalarm.so.0.0.0
b41a3000 b41c4000 r-xp /usr/lib/libefl-extension.so.0.1.0
b41c5000 b41ce000 r-xp /usr/lib/libappcore-watch.so.1.1
b41cf000 b41da000 r-xp /lib/libnss_files-2.13.so
b441b000 b4442000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4443000 b4468000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4469000 b458a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b459a000 b45d0000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b45d2000 b45d5000 r-xp /usr/lib/libiniparser.so.0
b45d7000 b45e2000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b45e3000 b45ec000 r-xp /usr/lib/libappsvc.so.0.1.0
b45ed000 b45f0000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b45f3000 b45f6000 r-xp /usr/lib/libdri2.so.0.0.0
b45f7000 b45f9000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b45fa000 b45fe000 r-xp /opt/usr/apps/org.example.stemwatch/bin/stemwatch
b45ff000 b4605000 r-xp /usr/lib/libogg.so.0.7.1
b4606000 b4631000 r-xp /usr/lib/libvorbis.so.0.4.3
b4632000 b471d000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b472b000 b472d000 r-xp /usr/lib/libXau.so.6.0.0
b472e000 b478e000 r-xp /usr/lib/libssl.so.1.0.0
b4793000 b47c4000 r-xp /usr/lib/libidn.so.11.5.44
b47c5000 b47d5000 r-xp /usr/lib/libcares.so.2.1.0
b47d6000 b483f000 r-xp /usr/lib/libsndfile.so.1.0.25
b4845000 b484f000 r-xp /usr/lib/libsensord-share.so
b4850000 b4876000 r-xp /lib/libexpat.so.1.5.2
b4878000 b489f000 r-xp /usr/lib/libpng12.so.0.50.0
b48a0000 b48c0000 r-xp /usr/lib/libxcb.so.1.1.0
b48c1000 b4930000 r-xp /usr/lib/libcurl.so.4.3.0
b4932000 b493d000 r-xp /usr/lib/libethumb.so.1.7.99
b5e9d000 b5f75000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f81000 b5f84000 r-xp /usr/lib/libctxdata.so.0.0.0
b5f85000 b5f9b000 r-xp /usr/lib/libremix.so.0.0.0
b5f9c000 b5f9e000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f9f000 b5fcb000 r-xp /usr/lib/liblua-5.1.so
b5fcc000 b5fd6000 r-xp /usr/lib/libembryo.so.1.7.99
b5fd7000 b601d000 r-xp /usr/lib/libjpeg.so.8.0.2
b602e000 b604c000 r-xp /usr/lib/libsensor.so.1.1.0
b604e000 b60d0000 r-xp /usr/lib/libpixman-1.so.0.28.2
b60d5000 b6109000 r-xp /usr/lib/libfontconfig.so.1.5.0
b610b000 b6166000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6168000 b617e000 r-xp /usr/lib/libfribidi.so.0.3.1
b617f000 b620b000 r-xp /usr/lib/libfreetype.so.6.11.3
b620f000 b6212000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6213000 b6219000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b621a000 b6220000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6222000 b6233000 r-xp /usr/lib/libXext.so.6.4.0
b6234000 b6368000 r-xp /usr/lib/libX11.so.6.3.0
b636c000 b6371000 r-xp /usr/lib/libXtst.so.6.1.0
b6372000 b637a000 r-xp /usr/lib/libXrender.so.1.3.0
b637b000 b6384000 r-xp /usr/lib/libXrandr.so.2.2.0
b6385000 b6387000 r-xp /usr/lib/libXinerama.so.1.0.0
b6388000 b6396000 r-xp /usr/lib/libXi.so.6.1.0
b6397000 b639b000 r-xp /usr/lib/libXfixes.so.3.1.0
b639c000 b639e000 r-xp /usr/lib/libXgesture.so.7.0.0
b639f000 b63a1000 r-xp /usr/lib/libXcomposite.so.1.0.0
b63a2000 b63a4000 r-xp /usr/lib/libXdamage.so.1.1.0
b63a5000 b63ae000 r-xp /usr/lib/libXcursor.so.1.0.2
b63af000 b63da000 r-xp /usr/lib/libecore_con.so.1.7.99
b63dc000 b63e4000 r-xp /usr/lib/libecore_imf.so.1.7.99
b63e5000 b63f0000 r-xp /usr/lib/libethumb_client.so.1.7.99
b63f1000 b63f7000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b63f8000 b6419000 r-xp /usr/lib/libefreet.so.1.7.99
b641b000 b6427000 r-xp /usr/lib/libedbus.so.1.7.99
b6428000 b6587000 r-xp /usr/lib/libicuuc.so.51.1
b6595000 b679e000 r-xp /usr/lib/libicui18n.so.51.1
b67a7000 b6844000 r-xp /usr/lib/libedje.so.1.7.99
b6846000 b6857000 r-xp /usr/lib/libecore_input.so.1.7.99
b6858000 b685f000 r-xp /usr/lib/libecore_file.so.1.7.99
b6860000 b6886000 r-xp /usr/lib/libeet.so.1.7.99
b688f000 b69b7000 r-xp /usr/lib/libevas.so.1.7.99
b69d4000 b6a07000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6a09000 b6a4d000 r-xp /usr/lib/libecore_x.so.1.7.99
b6a4f000 b6c49000 r-xp /usr/lib/libelementary.so.1.7.99
b6c5a000 b6c60000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6c61000 b6c65000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6c69000 b6c6a000 r-xp /usr/lib/libjournal.so.0.1.0
b6c6b000 b6db3000 r-xp /usr/lib/libxml2.so.2.7.8
b6dba000 b6dcd000 r-xp /lib/libresolv-2.13.so
b6dd1000 b6dee000 r-xp /lib/libz.so.1.2.5
b6def000 b6df2000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6df3000 b6df8000 r-xp /usr/lib/libffi.so.5.0.10
b6df9000 b6dfa000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6dfc000 b6e00000 r-xp /lib/libattr.so.1.1.0
b6e01000 b7013000 r-xp /usr/lib/libcrypto.so.1.0.0
b702e000 b704f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b7050000 b7078000 r-xp /lib/libm-2.13.so
b707a000 b70d5000 r-xp /usr/lib/libeina.so.1.7.99
b70d8000 b70e3000 r-xp /usr/lib/libvconf.so.0.2.45
b70e4000 b70e7000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b70e8000 b7136000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b7137000 b7298000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b729c000 b72a3000 r-xp /lib/librt-2.13.so
b72a6000 b72ad000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b72af000 b72c9000 r-xp /lib/libgcc_s-4.6.4.so.1
b72ca000 b72d2000 r-xp /lib/libcrypt-2.13.so
b72fb000 b72ff000 r-xp /lib/libcap.so.2.21
b7300000 b7302000 r-xp /usr/lib/libiri.so
b7304000 b7330000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b7331000 b7351000 r-xp /usr/lib/libecore.so.1.7.99
b7360000 b7369000 r-xp /usr/lib/libxdgmime.so.1.1.0
b736a000 b748d000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b748e000 b74a1000 r-xp /usr/lib/libail.so.0.1.0
b74a3000 b74c8000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b74c9000 b74d3000 r-xp /lib/libunwind.so.8.0.1
b74dd000 b764e000 r-xp /lib/libc-2.13.so
b7654000 b769e000 r-xp /usr/lib/libdbus-1.so.3.7.2
b769f000 b76a4000 r-xp /usr/lib/libbundle.so.0.1.22
b76a5000 b76a8000 r-xp /lib/libdl-2.13.so
b76ab000 b76b0000 r-xp /usr/lib/libsmack.so.1.0.0
b76b1000 b7759000 r-xp /usr/lib/libsqlite3.so.0.8.6
b775c000 b7776000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b7777000 b778e000 r-xp /lib/libpthread-2.13.so
b7792000 b7795000 r-xp /usr/lib/libdlog.so.0.0.0
b7796000 b77a6000 r-xp /usr/lib/libaul.so.0.1.0
b77a8000 b77ae000 r-xp /usr/lib/libappcore-common.so.1.1
b77af000 b77b4000 r-xp /usr/lib/libappcore-efl.so.1.1
b77b6000 b77bb000 r-xp /usr/lib/libsys-assert.so
b77be000 b77dc000 r-xp /lib/ld-2.13.so
b77dc000 b77dd000 r-xp [vdso]
b77df000 b77e6000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:4441)
Call Stack Count: 14
 0: (0xb7551fef) [/lib/libc.so.6] + 0x74fef
 1: (0xb6b0ce50) [/usr/lib/libelementary.so.1] + 0xbde50
 2: (0xb6b0e337) [/usr/lib/libelementary.so.1] + 0xbf337
 3: (0xb6b10962) [/usr/lib/libelementary.so.1] + 0xc1962
 4: (0xb6b112e4) [/usr/lib/libelementary.so.1] + 0xc22e4
 5: (0xb6b11aea) [/usr/lib/libelementary.so.1] + 0xc2aea
 6: (0xb733d852) [/usr/lib/libecore.so.1] + 0xc852
 7: (0xb733f2fd) [/usr/lib/libecore.so.1] + 0xe2fd
 8: ecore_main_loop_begin + 0x3f (0xb733f9cf) [/usr/lib/libecore.so.1] + 0xe9cf
 9: watch_core_main + 0x172 (0xb41c8c72) [/usr/lib/libappcore-watch.so.1] + 0x3c72
10: watch_app_main + 0xd6 (0xb41ca686) [/usr/lib/libappcore-watch.so.1] + 0x5686
11: main + 0x142 (0xb45fbcc2) [/opt/usr/apps/org.example.stemwatch/bin/stemwatch] + 0x1cc2
12: (0xb77e25b1) [/opt/usr/apps/org.example.stemwatch/bin/stemwatch] + 0xb77e25b1
13: __libc_start_main + 0xf3 (0xb74f60f3) [/lib/libc.so.6] + 0x190f3
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
[SECURE_LOG] Sync context created: org.example.stemwatch (4441)
05-22 03:25:06.844+0900 D/COM_CORE( 2289): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [56] New TCB created: R(57), W(58)
05-22 03:25:06.844+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 56 (server: 4)
05-22 03:25:06.844+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: slave_hello_sync(8248) > [SECURE_LOG] New slave[4441.1839.842866](4441) is arrived.
05-22 03:25:06.844+0900 D/AUL_AMD ( 2179): amd_request.c: __request_handler(495) > __request_handler: 15
05-22 03:25:06.844+0900 D/AUL_AMD ( 2179): amd_status.c: _status_get_appid_bypid(432) > [SECURE_LOG] appid for 4441 is org.example.stemwatch
05-22 03:25:06.844+0900 D/AUL_AMD ( 2179): amd_request.c: __request_handler(671) > APP_GET_APPID_BYPID : 4441 : 0
05-22 03:25:06.844+0900 D/AUL     ( 2289): app_sock.c: __app_send_cmd_with_result(618) > recv result  = 30
05-22 03:25:06.844+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: slave_hello_sync(8352) > [SECURE_LOG] Hello sync context found: org.example.stemwatch
05-22 03:25:06.844+0900 D/AUL_AMD ( 2179): amd_request.c: __request_handler(495) > __request_handler: 15
05-22 03:25:06.844+0900 D/AUL_AMD ( 2179): amd_status.c: _status_get_appid_bypid(432) > [SECURE_LOG] appid for 4441 is org.example.stemwatch
05-22 03:25:06.844+0900 D/AUL_AMD ( 2179): amd_request.c: __request_handler(671) > APP_GET_APPID_BYPID : 4441 : 0
05-22 03:25:06.854+0900 D/AUL     ( 2289): app_sock.c: __app_send_cmd_with_result(618) > recv result  = 30
05-22 03:25:06.854+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: slave_hello_sync(8418) > [SECURE_LOG] [org.example.stemwatch] Instance Count: 1
05-22 03:25:06.854+0900 D/DATA_PROVIDER_MASTER( 2289): slave_life.c: slave_set_valid(2155) > [SECURE_LOG] slave is set valid
05-22 03:25:06.854+0900 D/DATA_PROVIDER_MASTER( 2289): slave_rpc.c: slave_rpc_update_handle(518) > [SECURE_LOG] SLAVE: New handle assigned for 4441, 51
05-22 03:25:06.854+0900 D/DATA_PROVIDER_MASTER( 2289): package.c: slave_activated_cb(154) > [SECURE_LOG] Do not need to reactivate instances
05-22 03:25:06.854+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: slave_hello_sync(8448) > [SECURE_LOG] Slave is activated by request: 4441 (org.example.stemwatch)/(4441.1839.842866)
05-22 03:25:06.854+0900 D/DATA_PROVIDER_MASTER( 2289): instance.c: instance_watch_change_package_info(4000) > [SECURE_LOG] Package information is not touched (org.example.stemwatch)
05-22 03:25:06.854+0900 D/DATA_PROVIDER_MASTER( 2289): instance.c: instance_duplicate_packet_create(1109) > [SECURE_LOG] [TODO] Instance package info: 0xb82d95c0:org.example.stemwatch
05-22 03:25:06.854+0900 D/DATA_PROVIDER_MASTER( 2289): instance.c: instance_duplicate_packet_create(1137) > [SECURE_LOG] [TODO] Instance request_state is not touched
05-22 03:25:06.854+0900 D/DATA_PROVIDER_MASTER( 2289): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
05-22 03:25:06.854+0900 D/COM_CORE( 4441): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2289, fd: -1
05-22 03:25:06.854+0900 D/COM_CORE( 4441): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 165 bytes (pid: 2289), fd: -1
05-22 03:25:06.854+0900 D/COM_CORE( 4441): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
05-22 03:25:06.854+0900 D/WIDGET_PROVIDER_APP( 4441): client.c: method_new(475) > [SECURE_LOG] Create: pkgname[org.example.stemwatch], id[file:///opt/usr/share/live_magazine/org.example.stemwatch_2272_1839.665283.png], content[], timeout[10], has_script[0], period[0.000000], cluster[user,created], category[default], skip[1], abi[app], size: 360x360, ori: 0
05-22 03:25:06.854+0900 D/WATCH_CORE( 4441): appcore-watch.c: __widget_create(870) > widget_create
05-22 03:25:06.854+0900 W/CAPI_WATCH_APPLICATION( 4441): watch_app_main.c: _watch_core_create(205) > _watch_core_create
05-22 03:25:06.854+0900 D/WIDGET  ( 4441): binder.c: load_ecore_evas_function(98) > [SECURE_LOG] pixmap_allocfunc_new is not found
05-22 03:25:06.854+0900 D/WIDGET  ( 4441): binder.c: load_ecore_evas_function(103) > [SECURE_LOG] allocfunc_with_stirde_new is not found
05-22 03:25:06.854+0900 D/WIDGET_PROVIDER( 4441): widget_provider_buffer.c: widget_provider_buffer_create(2015) > [SECURE_LOG] acquire_buffer: [WIDGET] file:///opt/usr/share/live_magazine/org.example.stemwatch_2272_1839.665283.png, handler: 0xb41784d0
05-22 03:25:06.854+0900 D/WIDGET  ( 4441): binder.c: binder_ecore_evas_new(522) > [SECURE_LOG] Preferred engine: (null) (opengl or opengl_x11)
05-22 03:25:06.854+0900 D/WIDGET_PROVIDER( 4441): widget_provider_buffer.c: widget_provider_buffer_acquire(2087) > [SECURE_LOG] acquire_buffer: [WIDGET] file:///opt/usr/share/live_magazine/org.example.stemwatch_2272_1839.665283.png, 1x1, size: 4, handler: 0xb41784d0
05-22 03:25:06.854+0900 D/COM_CORE( 2289): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [61] New TCB created: R(62), W(63)
05-22 03:25:06.854+0900 E/COM_CORE( 2289): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
05-22 03:25:06.854+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (56)
05-22 03:25:06.854+0900 D/COM_CORE( 2289): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
05-22 03:25:06.854+0900 D/COM_CORE( 2289): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
05-22 03:25:06.854+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
05-22 03:25:06.854+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
05-22 03:25:06.854+0900 D/COM_CORE( 2289): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(56) for pid(-1)
05-22 03:25:06.854+0900 E/COM_CORE( 2289): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
05-22 03:25:06.854+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 61 (server: 4)
05-22 03:25:06.854+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: buffer_handler_resize(1047) > [SECURE_LOG] Buffer size is updated[1x1]
05-22 03:25:06.854+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: load_pixmap_buffer(539) > [SECURE_LOG] Loaded pixmap(info->id): pixmap://16777246:4
05-22 03:25:06.854+0900 D/COM_CORE( 4441): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2289, fd: -1
05-22 03:25:06.854+0900 D/COM_CORE( 4441): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 24 bytes (pid: 2289), fd: -1
05-22 03:25:06.854+0900 D/COM_CORE( 4441): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
05-22 03:25:06.854+0900 D/WIDGET_PROVIDER( 4441): fb.c: fb_create(610) > [SECURE_LOG] PIXMAP: 16777246
05-22 03:25:06.854+0900 D/WIDGET_PROVIDER( 4441): widget_provider_buffer.c: send_acquire_request(148) > [SECURE_LOG] type: 0x0, name: 4441.1839.842866, pkgname[org.example.stemwatch], id[file:///opt/usr/share/live_magazine/org.example.stemwatch_2272_1839.665283.png], w[1], h[1], size[4], buffer_id[pixmap://16777246:4], fb[0xb8fe9e78]
05-22 03:25:06.864+0900 E/COM_CORE( 2289): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
05-22 03:25:06.864+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (61)
05-22 03:25:06.864+0900 D/COM_CORE( 2289): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
05-22 03:25:06.864+0900 D/COM_CORE( 2289): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
05-22 03:25:06.864+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
05-22 03:25:06.864+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
05-22 03:25:06.864+0900 D/COM_CORE( 2289): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(61) for pid(-1)
05-22 03:25:06.864+0900 E/COM_CORE( 2289): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
05-22 03:25:06.874+0900 D/WIDGET_PROVIDER( 4441): fb.c: create_gem(509) > [SECURE_LOG] dri2_buffer: 0xb8fed8d0, name: 0x3, 1x1 (1x1), pitch: 4, buf_count: 1, gem: 0xb8fed7d8
05-22 03:25:06.874+0900 D/WIDGET  ( 4441): binder.c: alloc_fb(430) > [SECURE_LOG] HW Accelerated buffer is created 0xb8fe5830, (1x1)
05-22 03:25:06.874+0900 D/WIDGET  ( 4441): binder.c: load_update_function(128) > [SECURE_LOG] App detected
05-22 03:25:06.874+0900 D/WIDGET_PROVIDER( 4441): fb.c: destroy_gem(524) > [SECURE_LOG] unref pixmap bo
05-22 03:25:06.874+0900 D/WIDGET  ( 4441): binder.c: free_fb(481) > [SECURE_LOG] HW Accelerated buffer is destroyed
05-22 03:25:06.874+0900 D/COM_CORE( 2289): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [56] New TCB created: R(57), W(58)
05-22 03:25:06.874+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 56 (server: 4)
05-22 03:25:06.874+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: destroy_pixmap(343) > [SECURE_LOG] pixmap 16777246
05-22 03:25:06.874+0900 D/COM_CORE( 4441): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2289, fd: -1
05-22 03:25:06.874+0900 D/COM_CORE( 4441): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2289), fd: -1
05-22 03:25:06.874+0900 D/COM_CORE( 4441): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
05-22 03:25:06.874+0900 D/WIDGET  ( 4441): widget.c: widget_viewer_release_buffer(609) > [SECURE_LOG] Release buffer: -1 (0)
05-22 03:25:06.874+0900 D/WIDGET  ( 4441): binder.c: alloc_fb(409) > [SECURE_LOG] Size of ee is updated: 360x360 (info: 0xb8fe5830)
05-22 03:25:06.874+0900 D/WIDGET_PROVIDER( 4441): widget_provider_buffer.c: widget_provider_buffer_acquire(2087) > [SECURE_LOG] acquire_buffer: [WIDGET] file:///opt/usr/share/live_magazine/org.example.stemwatch_2272_1839.665283.png, 360x360, size: 4, handler: 0xb41784d0
05-22 03:25:06.874+0900 D/COM_CORE( 2289): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [61] New TCB created: R(62), W(63)
05-22 03:25:06.884+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 61 (server: 4)
05-22 03:25:06.884+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: buffer_handler_resize(1047) > [SECURE_LOG] Buffer size is updated[360x360]
05-22 03:25:06.884+0900 E/COM_CORE( 2289): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
05-22 03:25:06.884+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (56)
05-22 03:25:06.894+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: load_pixmap_buffer(539) > [SECURE_LOG] Loaded pixmap(info->id): pixmap://16777248:4
05-22 03:25:06.894+0900 D/COM_CORE( 2289): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
05-22 03:25:06.894+0900 D/COM_CORE( 2289): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
05-22 03:25:06.894+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
05-22 03:25:06.894+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
05-22 03:25:06.894+0900 D/COM_CORE( 2289): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(56) for pid(-1)
05-22 03:25:06.894+0900 E/COM_CORE( 2289): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
05-22 03:25:06.894+0900 D/COM_CORE( 4441): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2289, fd: -1
05-22 03:25:06.894+0900 D/COM_CORE( 4441): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 24 bytes (pid: 2289), fd: -1
05-22 03:25:06.894+0900 D/COM_CORE( 4441): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
05-22 03:25:06.894+0900 D/WIDGET_PROVIDER( 4441): fb.c: fb_create(610) > [SECURE_LOG] PIXMAP: 16777248
05-22 03:25:06.894+0900 D/WIDGET_PROVIDER( 4441): widget_provider_buffer.c: send_acquire_request(148) > [SECURE_LOG] type: 0x0, name: 4441.1839.842866, pkgname[org.example.stemwatch], id[file:///opt/usr/share/live_magazine/org.example.stemwatch_2272_1839.665283.png], w[360], h[360], size[4], buffer_id[pixmap://16777248:4], fb[0xb8ff2458]
05-22 03:25:06.894+0900 E/COM_CORE( 2289): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
05-22 03:25:06.894+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (61)
05-22 03:25:06.894+0900 D/COM_CORE( 2289): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
05-22 03:25:06.894+0900 D/COM_CORE( 2289): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
05-22 03:25:06.894+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
05-22 03:25:06.894+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
05-22 03:25:06.894+0900 D/COM_CORE( 2289): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(61) for pid(-1)
05-22 03:25:06.894+0900 E/COM_CORE( 2289): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
05-22 03:25:06.894+0900 D/WIDGET_PROVIDER( 4441): fb.c: create_gem(509) > [SECURE_LOG] dri2_buffer: 0xb8ff28b8, name: 0x3, 360x360 (360x360), pitch: 1440, buf_count: 1, gem: 0xb8fed7d8
05-22 03:25:06.894+0900 D/WIDGET  ( 4441): binder.c: alloc_fb(430) > [SECURE_LOG] HW Accelerated buffer is created 0xb8fe5830, (360x360)
05-22 03:25:06.924+0900 D/WIDGET_VIEWER( 2272): client.c: master_update_id(1650) > [SECURE_LOG] Update ID(file:///opt/usr/share/live_magazine/org.example.stemwatch_2272_1839.665283.png) for 1839.665283
05-22 03:25:06.984+0900 E/WIDGET_VIEWER( 2272): client.c: master_created(1711) > [SECURE_LOG] [1839.665283] pkgname: org.example.stemwatch, id: file:///opt/usr/share/live_magazine/org.example.stemwatch_2272_1839.665283.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
05-22 03:25:06.984+0900 D/WIDGET_VIEWER( 2272): fb.c: fb_create(376) > [SECURE_LOG] PIXMAP-SHMID: 0 is gotten (0)
05-22 03:25:06.984+0900 D/WIDGET_VIEWER( 2272): widget.c: _widget_set_visibility(1143) > [SECURE_LOG] [org.example.stemwatch] visibility is changed 0x[0]
05-22 03:25:06.984+0900 D/WIDGET_EVAS( 2272): widget_viewer_evas.c: __widget_created_cb(4977) > [SECURE_LOG] Invoke raw create org.example.stemwatch
05-22 03:25:06.984+0900 D/WIDGET_EVAS( 2272): widget_viewer_evas.c: widget_unref(956) > [SECURE_LOG] refcnt: 1 (org.example.stemwatch)
05-22 03:25:06.984+0900 E/WIDGET_VIEWER( 2272): fb.c: fb_is_created(425) > [SECURE_LOG] access: 11 ((null))
05-22 03:25:06.984+0900 D/WIDGET_VIEWER( 2272): widget.c: widget_viewer_get_size_type(2679) > [SECURE_LOG] FB is not created yet, but give its size to the caller: 360x360
05-22 03:25:06.994+0900 E/EFL     ( 4441): eina_module<4441> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
05-22 03:25:07.034+0900 D/DATA_PROVIDER_MASTER( 2289): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
05-22 03:25:07.044+0900 D/WIDGET_VIEWER( 2272): fb.c: fb_create(376) > [SECURE_LOG] PIXMAP-SHMID: 16777246 is gotten (4)
05-22 03:25:07.044+0900 D/WIDGET_EVAS( 2272): widget_viewer_evas.c: __widget_event_widget_size_changed(6207) > [SECURE_LOG] widget LB size is changed
05-22 03:25:07.104+0900 E/WIDGET_VIEWER( 2272): widget.c: widget_viewer_get_size_type(2687) > [SECURE_LOG] widget_service_get_size_type failed : -22
05-22 03:25:07.104+0900 E/WIDGET_EVAS( 2272): widget_viewer_evas.c: __widget_event_widget_updated(5824) > [SECURE_LOG] Size is not valid FFFF
05-22 03:25:07.184+0900 D/WIDGET_VIEWER( 2272): fb.c: fb_create(376) > [SECURE_LOG] PIXMAP-SHMID: 16777248 is gotten (4)
05-22 03:25:07.184+0900 D/WIDGET_EVAS( 2272): widget_viewer_evas.c: __widget_event_widget_size_changed(6207) > [SECURE_LOG] widget LB size is changed
05-22 03:25:07.204+0900 D/WIDGET_EVAS( 2272): widget_viewer_evas.c: __widget_animation_done_cb(3470) > [SECURE_LOG] Animation finished
05-22 03:25:07.254+0900 D/WATCH_CORE( 4441): appcore-watch.c: __widget_create(888) > widget_create done
05-22 03:25:07.254+0900 D/ALARM_MANAGER( 4441): alarm-lib.c: alarmmgr_init(326) > [SECURE_LOG] Enter
05-22 03:25:07.294+0900 D/ALARM_MANAGER( 4441): alarm-lib.c: __sub_init(312) > [SECURE_LOG] alarm_context.pid is set to processID, 4441.
05-22 03:25:07.294+0900 D/ALARM_MANAGER( 4441): alarm-lib.c: alarmmgr_init(369) > [SECURE_LOG] [alarm-lib]: dbus own name: ALARM.aorg.aexample.astemwatch
05-22 03:25:07.294+0900 D/ALARM_MANAGER( 4441): alarm-lib.c: alarmmgr_init(397) > [SECURE_LOG] Leave
05-22 03:25:07.294+0900 E/WIDGET_PROVIDER( 4441): widget_provider.c: widget_provider_send_hello_sync(1600) > [SECURE_LOG] #widget_create return [0]
05-22 03:25:07.294+0900 D/WIDGET_PROVIDER( 4441): widget_provider.c: initialize_provider(1260) > [SECURE_LOG] Slave is initialized
05-22 03:25:07.294+0900 E/WIDGET_PROVIDER_APP( 4441): client.c: client_init_sync(1342) > [SECURE_LOG] widget_provider_init return [0]
05-22 03:25:07.294+0900 D/WATCH_CORE( 4441): appcore-watch.c: __watch_core_widget_init(1014) > succeded to initialize the widget
05-22 03:25:07.294+0900 D/WATCH_CORE( 4441): appcore-watch-signal.c: _watch_core_listen_alpm_handler(141) > watch_core_listen_deviced_alpm
05-22 03:25:07.424+0900 D/WIDGET_EVAS( 2272): widget_viewer_evas.c: acquire_widget_pixmap_cb(4751) > [SECURE_LOG] fillset: 360x360
05-22 03:25:07.424+0900 D/WIDGET_EVAS( 2272): widget_viewer_evas.c: widget_unref(956) > [SECURE_LOG] refcnt: 1 (org.example.stemwatch)
05-22 03:25:07.464+0900 D/WATCH_CORE( 4441): appcore-watch.c: __widget_resume(922) > widget_resume
05-22 03:25:07.464+0900 D/WATCH_CORE( 4441): appcore-watch.c: __do_app(332) > WE_RESUME
05-22 03:25:07.464+0900 W/CAPI_WATCH_APPLICATION( 4441): watch_app_main.c: _watch_core_resume(262) > _watch_core_resume
05-22 03:25:07.464+0900 D/WATCH_CORE( 4441): appcore-watch.c: __watch_core_time_tick(834) > state: 2
05-22 03:25:07.464+0900 D/WATCH_CORE( 4441): appcore-watch.c: __watch_core_time_tick(845) > next time tick: 0.521000
05-22 03:25:07.464+0900 I/CAPI_WATCH_APPLICATION( 4441): watch_app_main.c: _watch_core_time_tick(301) > _watch_core_time_tick
05-22 03:25:07.564+0900 D/WATCH_CORE( 4441): appcore-watch.c: __do_app(273) > appcontrol request
05-22 03:25:07.564+0900 D/WATCH_CORE( 4441): appcore-watch.c: __do_app(288) > widget is initialized
05-22 03:25:07.564+0900 W/CAPI_WATCH_APPLICATION( 4441): watch_app_main.c: _watch_core_control(228) > _watch_core_control
05-22 03:25:07.694+0900 D/PKGMGR_INFO( 4288): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.stemwatch/bin/stemwatch' and package_app_info.app_disable IN ('false','False')
05-22 03:25:07.694+0900 D/PKGMGR_INFO( 4288): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.stemwatch/bin/stemwatch' and package_app_info.app_disable IN ('false','False')
05-22 03:25:07.694+0900 D/PKGMGR_INFO( 4288): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.stemwatch/bin/stemwatch' and package_app_info.app_disable IN ('false','False')
05-22 03:25:07.694+0900 D/PKGMGR_INFO( 4288): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.stemwatch/bin/stemwatch' and package_app_info.app_disable IN ('false','False')
05-22 03:25:07.694+0900 D/PKGMGR_INFO( 4288): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.stemwatch/bin/stemwatch' and package_app_info.app_disable IN ('false','False')
05-22 03:25:07.694+0900 D/PKGMGR_INFO( 4288): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.stemwatch/bin/stemwatch' and package_app_info.app_disable IN ('false','False')
05-22 03:25:07.814+0900 D/AUL_AMD ( 2179): amd_launch.c: __grab_timeout_handler(1212) > pid(4441) ecore_x_pointer_ungrab
05-22 03:25:07.814+0900 D/AUL_AMD ( 2179): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.example.stemwatch /opt/usr/apps/org.example.stemwatch/bin/stemwatch
05-22 03:25:07.814+0900 D/RUA     ( 2179): rua.c: rua_add_history(179) > rua_add_history start
05-22 03:25:07.824+0900 D/RUA     ( 2179): rua.c: rua_add_history(247) > rua_add_history ok
05-22 03:25:07.884+0900 D/AUL     ( 4460): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.tizen.crash-popup
05-22 03:25:07.884+0900 D/AUL     ( 4460): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
05-22 03:25:07.884+0900 D/AUL_AMD ( 2179): amd_request.c: __request_handler(495) > __request_handler: 0
05-22 03:25:07.884+0900 D/AUL_AMD ( 2179): amd_request.c: __request_handler(540) > launch a single-instance appid: org.tizen.crash-popup
05-22 03:25:07.884+0900 D/AUL     ( 2179): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2114, pid = 4460
05-22 03:25:07.884+0900 D/AUL_AMD ( 2179): amd_launch.c: _start_app(1479) > [SECURE_LOG] caller : (null)
05-22 03:25:07.884+0900 D/AUL_AMD ( 2179): amd_launch.c: _start_app(1785) > process_pool: false
05-22 03:25:07.884+0900 D/AUL_AMD ( 2179): amd_launch.c: _start_app(1788) > h/w acceleration: SYS
05-22 03:25:07.884+0900 D/AUL_AMD ( 2179): amd_launch.c: _start_app(1790) > [SECURE_LOG] appid: org.tizen.crash-popup
05-22 03:25:07.884+0900 D/AUL_AMD ( 2179): amd_launch.c: __set_appinfo_for_launchpad(1950) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-22 03:25:07.884+0900 D/AUL     ( 2179): app_sock.c: __app_send_raw(265) > pid(-1) : cmd(0)
05-22 03:25:07.894+0900 D/AUL_PAD ( 2205): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.tizen.crash-popup
05-22 03:25:07.894+0900 D/AUL_PAD ( 2205): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
05-22 03:25:07.894+0900 D/AUL_PAD ( 2205): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 4461 /usr/apps/org.tizen.crash-popup/bin/crash-popup
05-22 03:25:07.894+0900 D/AUL_PAD ( 2205): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
05-22 03:25:07.894+0900 D/AUL_PAD ( 4461): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
05-22 03:25:07.894+0900 D/AUL_PAD ( 4461): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
05-22 03:25:07.894+0900 D/AUL_PAD ( 4461): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.tizen.crash-popup / pkg_type : rpm / app_path : /usr/apps/org.tizen.crash-popup/bin/crash-popup 
05-22 03:25:07.894+0900 D/AUL_PAD ( 4461): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
05-22 03:25:07.894+0900 D/AUL_PAD ( 4461): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /usr/apps/org.tizen.crash-popup/bin/crash-popup##
05-22 03:25:07.894+0900 D/AUL_PAD ( 4461): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : _PROCESS_NAME_##
05-22 03:25:07.894+0900 D/AUL_PAD ( 4461): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : _EXEPATH_##
05-22 03:25:07.894+0900 D/AUL_PAD ( 4461): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : _INTERNAL_SYSPOPUP_NAME_##
05-22 03:25:07.894+0900 D/AUL_PAD ( 4461): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_STARTTIME__##
05-22 03:25:07.894+0900 D/AUL_PAD ( 4461): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_PID__##
05-22 03:25:07.894+0900 D/LAUNCH  ( 4461): launchpad.c: __real_launch(229) > [SECURE_LOG] [/usr/apps/org.tizen.crash-popup/bin/crash-popup:Platform:launchpad:done]
05-22 03:25:07.934+0900 D/LAUNCH  ( 4461): appcore-efl.c: appcore_efl_main(1571) > [crash-popup:Application:main:done]
05-22 03:25:07.944+0900 D/APP_CORE( 4461): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
05-22 03:25:07.954+0900 D/AUL     ( 4461): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 4461 is org.tizen.crash-popup
05-22 03:25:07.954+0900 D/APP_CORE( 4461): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
05-22 03:25:07.954+0900 D/APP_CORE( 4461): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
05-22 03:25:07.954+0900 D/AUL     ( 4461): app_sock.c: __create_server_sock(136) > pg path - already exists
05-22 03:25:07.954+0900 D/LAUNCH  ( 4461): appcore-efl.c: __before_loop(1035) > [crash-popup:Platform:appcore_init:done]
05-22 03:25:07.964+0900 D/EFL-ASSIST( 4461): efl_assist_theme.c: ea_theme_changeable_ui_enabled_set(267) > changeable state is set to 1
05-22 03:25:07.964+0900 D/EFL-ASSIST( 4461): efl_assist_theme.c: _theme_color_monitor_add(239) > color config file (/opt/home/app/.elementary/config/wearable/color.cfg) monitor is added!!
05-22 03:25:07.964+0900 I/EFL-ASSIST( 4461): efl_assist_theme.c: _theme_changeable_ui_data_set(220) > changeable state [1] is set to ecore_evas [b8fc1ab8]
05-22 03:25:07.964+0900 D/EFL-ASSIST( 4461): efl_assist_theme_color.c: ea_theme_style_set(951) > changeable state: 1,  winset style (0)
05-22 03:25:07.964+0900 I/EFL-ASSIST( 4461): efl_assist_theme_color.c: _color_config_get(215) > read color config file from (/opt/home/app/.elementary/config/wearable/color.cfg)
05-22 03:25:07.964+0900 I/EFL-ASSIST( 4461): efl_assist_theme_color.c: ea_theme_color_table_new(751) > color table (b8fea068) from (/usr/share/themes/ChangeableColorTable1.xml) is created
05-22 03:25:07.964+0900 I/EFL-ASSIST( 4461): efl_assist_theme_color.c: ea_theme_color_table_free(766) > color table (b8fea068) is freed
05-22 03:25:07.964+0900 I/EFL-ASSIST( 4461): efl_assist_theme_color.c: ea_theme_color_table_new(751) > color table (0) from (system-color.xml) is created
05-22 03:25:07.964+0900 I/EFL-ASSIST( 4461): efl_assist_theme_font.c: ea_theme_font_table_new(381) > font table (0) from (system-font.xml) is created
05-22 03:25:07.964+0900 D/APP_CORE( 4461): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
05-22 03:25:07.964+0900 D/LAUNCH  ( 4461): appcore-efl.c: __before_loop(1047) > [crash-popup:Application:create:done]
05-22 03:25:07.964+0900 D/APP_CORE( 4461): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
05-22 03:25:07.964+0900 D/APP_CORE( 4461): appcore.c: __aul_handler(423) > [APP 4461]     AUL event: AUL_START
05-22 03:25:07.964+0900 D/APP_CORE( 4461): appcore-efl.c: __do_app(470) > [APP 4461] Event: RESET State: CREATED
05-22 03:25:07.964+0900 D/APP_CORE( 4461): appcore-efl.c: __do_app(496) > [APP 4461] RESET
05-22 03:25:07.964+0900 D/LAUNCH  ( 4461): appcore-efl.c: __do_app(498) > [crash-popup:Application:reset:start]
05-22 03:25:07.974+0900 D/CRASH_POPUP( 4461): crash.c: app_reset(226) > bundle_get_val - process_name:stemwatch
05-22 03:25:07.974+0900 D/CRASH_POPUP( 4461): crash.c: app_reset(234) > bundle_get_val - exepath:/opt/usr/apps/org.example.stemwatch/bin/stemwatch
05-22 03:25:07.974+0900 D/PKGMGR_INFO( 4461): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.stemwatch/bin/stemwatch' and package_app_info.app_disable IN ('false','False')
05-22 03:25:07.974+0900 D/PKGMGR_INFO( 4461): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.stemwatch/bin/stemwatch' and package_app_info.app_disable IN ('false','False')
05-22 03:25:07.984+0900 D/PKGMGR_INFO( 4461): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.stemwatch/bin/stemwatch' and package_app_info.app_disable IN ('false','False')
05-22 03:25:07.984+0900 D/PKGMGR_INFO( 4461): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.stemwatch/bin/stemwatch' and package_app_info.app_disable IN ('false','False')
05-22 03:25:07.984+0900 I/CRASH_POPUP( 4461): crash.c: load_crash_process_popup(117) > Popup content: stemwatch has closed unexpectedly.
05-22 03:25:07.994+0900 D/AUL_PAD ( 2205): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
05-22 03:25:07.994+0900 D/AUL_PAD ( 2205): sigchild.h: __send_app_launch_signal(112) > send launch signal done
05-22 03:25:07.994+0900 D/AUL_PAD ( 2205): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
05-22 03:25:07.994+0900 D/WATCH_CORE( 4441): appcore-watch.c: __watch_core_time_tick(834) > state: 2
05-22 03:25:07.994+0900 D/WATCH_CORE( 4441): appcore-watch.c: __watch_core_time_tick(845) > next time tick: 0.995000
05-22 03:25:07.994+0900 I/CAPI_WATCH_APPLICATION( 4441): watch_app_main.c: _watch_core_time_tick(301) > _watch_core_time_tick
05-22 03:25:07.994+0900 D/AUL     ( 2179): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-22 03:25:07.994+0900 E/AUL     ( 2179): simple_util.c: __trm_app_info_send_socket(264) > access
05-22 03:25:08.004+0900 D/RESOURCED( 2364): proc-noti.c: recv_str(87) > [recv_str,87] str is null
05-22 03:25:08.004+0900 D/RESOURCED( 2364): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2179
05-22 03:25:08.004+0900 D/RESOURCED( 2364): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.tizen.crash-popup, pid 4461, type 4 
05-22 03:25:08.004+0900 D/RESOURCED( 2364): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.tizen.crash-popup, 4461
05-22 03:25:08.004+0900 D/RESOURCED( 2364): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.tizen.crash-popup with pkgname
05-22 03:25:08.004+0900 E/RESOURCED( 2364): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 373
05-22 03:25:08.004+0900 D/RESOURCED( 2364): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
05-22 03:25:08.004+0900 D/AUL     ( 4460): launch.c: app_request_to_launchpad(295) > launch request result : 4461
05-22 03:25:08.004+0900 E/EFL     ( 4461): eina_module<4461> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
05-22 03:25:08.044+0900 D/W_HOME  ( 2272): main.c: _window_focus_out_cb(869) > focus out
05-22 03:25:08.044+0900 D/W_HOME  ( 2272): main.c: _pause_cb(600) > Paused
05-22 03:25:08.064+0900 D/W_HOME  ( 2272): page.c: page_focus(701) > focus set to 0xb92f95e8
05-22 03:25:08.064+0900 W/W_HOME  ( 2272): main.c: _pause_cb(613) > clock/widget paused
05-22 03:25:08.064+0900 D/W_HOME  ( 2272): clock_view.c: clock_view_event_handler(843) > event:10002 received
05-22 03:25:08.064+0900 E/APPS    ( 2272): apps_main.c: _window_focus_out_cb(313) >  win[25165831], ev->win[25165827]
05-22 03:25:08.074+0900 D/DATA_PROVIDER_MASTER( 2289): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2272 is paused
05-22 03:25:08.074+0900 D/DATA_PROVIDER_MASTER( 2289): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-22 03:25:08.074+0900 D/WATCH_CORE( 4441): appcore-watch.c: __widget_pause(913) > widget_pause
05-22 03:25:08.074+0900 D/WATCH_CORE( 4441): appcore-watch.c: __do_app(299) > WE_PAUSE
05-22 03:25:08.074+0900 W/CAPI_WATCH_APPLICATION( 4441): watch_app_main.c: _watch_core_pause(245) > _watch_core_pause
05-22 03:25:08.084+0900 D/LAUNCH  ( 4461): appcore-efl.c: __do_app(501) > [crash-popup:Application:reset:done]
05-22 03:25:08.084+0900 I/APP_CORE( 4461): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
05-22 03:25:08.084+0900 I/APP_CORE( 4461): appcore-efl.c: __do_app(509) > [APP 4461] Initial Launching, call the resume_cb
05-22 03:25:08.084+0900 D/APP_CORE( 4461): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
05-22 03:25:08.104+0900 D/APP_CORE( 4461): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1e00006
05-22 03:25:08.104+0900 D/APP_CORE( 4461): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1e00006
05-22 03:25:08.164+0900 D/RESOURCED( 2364): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 4461, type = 0
05-22 03:25:08.164+0900 D/RESOURCED( 2364): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 4461
05-22 03:25:08.164+0900 I/RESOURCED( 2364): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 4461, oom : 200
05-22 03:25:08.164+0900 E/RESOURCED( 2364): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
05-22 03:25:08.164+0900 E/RESOURCED( 2364): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (4461) didn't have any process list
05-22 03:25:08.164+0900 D/RESOURCED( 2364): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 4461, appname = (null)
05-22 03:25:08.164+0900 D/RESOURCED( 2364): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 4461
05-22 03:25:08.164+0900 D/AUL_AMD ( 2179): amd_launch.c: __e17_status_handler(1911) > pid(4461) status(3)
05-22 03:25:08.264+0900 D/APP_CORE( 4461): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1e00006 fully_obscured 0
05-22 03:25:08.264+0900 D/APP_CORE( 4461): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
05-22 03:25:08.264+0900 D/APP_CORE( 4461): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
05-22 03:25:08.264+0900 D/APP_CORE( 4461): appcore-efl.c: __do_app(470) > [APP 4461] Event: RESUME State: RUNNING
05-22 03:25:08.264+0900 D/LAUNCH  ( 4461): appcore-efl.c: __do_app(557) > [crash-popup:Application:resume:start]
05-22 03:25:08.264+0900 D/LAUNCH  ( 4461): appcore-efl.c: __do_app(567) > [crash-popup:Application:resume:done]
05-22 03:25:08.264+0900 D/LAUNCH  ( 4461): appcore-efl.c: __do_app(569) > [crash-popup:Application:Launching:done]
05-22 03:25:08.264+0900 D/APP_CORE( 4461): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
05-22 03:25:08.264+0900 E/APP_CORE( 4461): appcore-efl.c: __trm_app_info_send_socket(233) > access
05-22 03:25:08.304+0900 I/GESTURE ( 1978): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
05-22 03:25:08.404+0900 D/EFL     ( 4461): ecore_x<4461> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=1841329 button=1
05-22 03:25:08.404+0900 D/APP_CORE( 4461): appcore.c: __prt_ltime(183) > [APP 4461] first idle after reset: 523 msec
05-22 03:25:08.514+0900 D/EFL     ( 4461): ecore_x<4461> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=1841446 button=1
05-22 03:25:09.004+0900 D/AUL_AMD ( 2179): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.tizen.crash-popup /usr/apps/org.tizen.crash-popup/bin/crash-popup
05-22 03:25:09.004+0900 D/RUA     ( 2179): rua.c: rua_add_history(179) > rua_add_history start
05-22 03:25:09.014+0900 D/RUA     ( 2179): rua.c: rua_add_history(247) > rua_add_history ok
05-22 03:25:10.694+0900 I/GESTURE ( 1978): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
05-22 03:25:10.744+0900 D/EFL     ( 4461): ecore_x<4461> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=1843702 button=1
05-22 03:25:10.854+0900 D/EFL     ( 4461): ecore_x<4461> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=1843858 button=1
05-22 03:25:10.854+0900 E/EFL     ( 4461): eina_module<4461> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
05-22 03:25:11.254+0900 D/AUL     ( 4461): app_sock.c: __app_send_raw_with_noreply(364) > pid(-2) : cmd(22)
05-22 03:25:11.254+0900 D/AUL_AMD ( 2179): amd_request.c: __request_handler(495) > __request_handler: 22
05-22 03:25:11.254+0900 D/APP_CORE( 4461): appcore-efl.c: __after_loop(1062) > [APP 4461] PAUSE before termination
05-22 03:25:11.254+0900 D/W_HOME  ( 2272): main.c: _window_focus_in_cb(848) > focus in
05-22 03:25:11.254+0900 D/W_HOME  ( 2272): main.c: _resume_cb(564) > Resumed
05-22 03:25:11.254+0900 D/APPS    ( 2272): apps_main.c: apps_main_is_visible(757) >  bShow:[0]
05-22 03:25:11.274+0900 D/W_HOME  ( 2272): scroller.c: _resume_result_cb(623) > Activate the rotary events for Home
05-22 03:25:11.274+0900 E/efl-extension( 2272): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb90e6070, elm_scroller, _activated_obj : 0xb90e6070, activated : 1
05-22 03:25:11.274+0900 D/W_HOME  ( 2272): clock_inf_widget.c: home_resumed_cb(277) > Thaw all freezed objects
05-22 03:25:11.274+0900 W/W_HOME  ( 2272): main.c: _resume_cb(589) > clock/widget resumed
05-22 03:25:11.284+0900 D/W_HOME  ( 2272): clock_view.c: clock_view_event_handler(843) > event:10004 received
05-22 03:25:11.284+0900 D/W_HOME  ( 2272): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
05-22 03:25:11.284+0900 E/APPS    ( 2272): apps_main.c: _window_focus_in_cb(293) >  win[25165831], ev->win[25165827]
05-22 03:25:11.294+0900 D/DATA_PROVIDER_MASTER( 2289): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2272 is resumed
05-22 03:25:11.294+0900 D/DATA_PROVIDER_MASTER( 2289): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
05-22 03:25:11.294+0900 D/WATCH_CORE( 4441): appcore-watch.c: __widget_resume(922) > widget_resume
05-22 03:25:11.294+0900 D/WATCH_CORE( 4441): appcore-watch.c: __do_app(332) > WE_RESUME
05-22 03:25:11.294+0900 W/CAPI_WATCH_APPLICATION( 4441): watch_app_main.c: _watch_core_resume(262) > _watch_core_resume
05-22 03:25:11.294+0900 D/WATCH_CORE( 4441): appcore-watch.c: __watch_core_time_tick(834) > state: 2
05-22 03:25:11.294+0900 D/WATCH_CORE( 4441): appcore-watch.c: __watch_core_time_tick(845) > next time tick: 0.697000
05-22 03:25:11.294+0900 I/CAPI_WATCH_APPLICATION( 4441): watch_app_main.c: _watch_core_time_tick(301) > _watch_core_time_tick
05-22 03:25:11.324+0900 I/AUL_PAD ( 2205): sigchild.h: __launchpad_sig_child(142) > dead_pid = 4461 pgid = 4461
05-22 03:25:11.324+0900 I/AUL_PAD ( 2205): sigchild.h: __sigchild_action(123) > dead_pid(4461)
05-22 03:25:11.324+0900 D/AUL_PAD ( 2205): sigchild.h: __send_app_dead_signal(81) > send dead signal done
05-22 03:25:11.324+0900 I/AUL_PAD ( 2205): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
05-22 03:25:11.324+0900 I/AUL_PAD ( 2205): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
05-22 03:25:11.324+0900 D/W_HOME  ( 2272): main.c: _dead_cb(542) > PID(4461) is dead
05-22 03:25:11.324+0900 E/W_HOME  ( 2272): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
05-22 03:25:11.324+0900 D/STARTER ( 2265): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 4461)
05-22 03:25:11.324+0900 I/AUL_AMD ( 2179): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4461
05-22 03:25:11.324+0900 D/AUL_AMD ( 2179): amd_key.c: _unregister_key_event(161) > ===key stack===
05-22 03:25:11.324+0900 D/AUL     ( 2179): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-22 03:25:11.324+0900 E/AUL     ( 2179): simple_util.c: __trm_app_info_send_socket(264) > access
05-22 03:25:11.894+0900 I/GESTURE ( 1978): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
05-22 03:25:11.944+0900 D/EFL     ( 2272): ecore_x<2272> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=1844900 button=1
05-22 03:25:11.944+0900 D/W_HOME  ( 2272): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
05-22 03:25:11.944+0900 D/W_HOME  ( 2272): dbus_util.c: home_dbus_scroll_booster_signal_send(296) > Sending scroll booster for 200 sec result:0
05-22 03:25:11.944+0900 D/W_HOME  ( 2272): layout.c: _down_cb(250) > Mouse is down on the layout
05-22 03:25:11.944+0900 W/W_HOME  ( 2272): layout.c: _down_cb(280) > we don't add a longpress timer, it's too close to home key
05-22 03:25:11.944+0900 D/W_HOME  ( 2272): layout.c: _gesture_down_cb(611) > Mouse is down on the gesture layer:302
05-22 03:25:11.944+0900 D/W_HOME  ( 2272): page.c: _down_cb(84) > Down (0xb92e6630)(196, 302)
05-22 03:25:11.944+0900 D/WIDGET_EVAS( 2272): widget_viewer_evas.c: __widget_down_cb(1500) > [SECURE_LOG] Change to direct render
05-22 03:25:11.944+0900 D/WIDGET_EVAS( 2272): widget_viewer_evas.c: __widget_down_cb(1540) > [SECURE_LOG] 196.000000x302.000000 (1.000000x1.000000)
05-22 03:25:11.974+0900 D/WIDGET_PROVIDER( 4441): widget_provider_buffer.c: provider_buffer_widget_mouse_down(603) > [SECURE_LOG] Down: file:///opt/usr/share/live_magazine/org.example.stemwatch_2272_1839.665283.png
05-22 03:25:11.974+0900 E/WIDGET  ( 4441): virtual_window.c: processing_events(212) > [SECURE_LOG] DOWN[/opt/usr/share/live_magazine/org.example.stemwatch_2272_1839.665283.png] 196x302 - 1844953.002930 (0)
05-22 03:25:11.994+0900 D/WATCH_CORE( 4441): appcore-watch.c: __watch_core_time_tick(834) > state: 2
05-22 03:25:11.994+0900 D/WATCH_CORE( 4441): appcore-watch.c: __watch_core_time_tick(845) > next time tick: 0.998000
05-22 03:25:11.994+0900 I/CAPI_WATCH_APPLICATION( 4441): watch_app_main.c: _watch_core_time_tick(301) > _watch_core_time_tick
05-22 03:25:12.034+0900 D/EFL     ( 2272): ecore_x<2272> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=1845048 button=1
05-22 03:25:12.034+0900 D/W_HOME  ( 2272): layout.c: _up_cb(324) > Mouse is up on the layout
05-22 03:25:12.034+0900 D/W_HOME  ( 2272): page.c: _up_cb(115) > Up (0xb92e6630)(196, 302)
05-22 03:25:12.034+0900 D/WIDGET_EVAS( 2272): widget_viewer_evas.c: __widget_up_cb(3047) > [SECURE_LOG] Change to render animator
05-22 03:25:12.034+0900 D/WIDGET_EVAS( 2272): widget_viewer_evas.c: __widget_up_cb(3177) > [SECURE_LOG] 196.000000x302.000000 (1.000000x1.000000)
05-22 03:25:12.034+0900 D/WIDGET_VIEWER( 2272): widget.c: widget_viewer_send_click_event(1876) > [SECURE_LOG] CLICKED: 1845.049805
05-22 03:25:12.034+0900 D/WIDGET_EVAS( 2272): widget_viewer_evas.c: __widget_up_cb(3199) > [SECURE_LOG] Up: 196.000000x302.000000 [x:0/1/0] [y:0/0/0], ret: 0x0, cancel: 0x0
05-22 03:25:12.054+0900 D/WIDGET_PROVIDER( 4441): widget_provider_buffer.c: provider_buffer_widget_mouse_up(639) > [SECURE_LOG] Up: file:///opt/usr/share/live_magazine/org.example.stemwatch_2272_1839.665283.png
05-22 03:25:12.054+0900 E/WIDGET  ( 4441): virtual_window.c: processing_events(248) > [SECURE_LOG] UP[/opt/usr/share/live_magazine/org.example.stemwatch_2272_1839.665283.png] 196x302 - 1845049.560547 (0)
05-22 03:25:12.054+0900 E/EFL     ( 4441): eina_module<4441> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/feedback/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
05-22 03:25:12.094+0900 I/efl-extension( 4441): efl_extension_rotary.c: eext_rotary_object_event_callback_add(163) > In
05-22 03:25:12.094+0900 E/efl-extension( 4441): efl_extension_rotary.c: eext_rotary_event_handler_add(93) > init_count: 0
05-22 03:25:12.094+0900 I/efl-extension( 4441): efl_extension_rotary.c: _init_Xi2_system(333) > In
05-22 03:25:12.094+0900 I/efl-extension( 4441): efl_extension_rotary.c: _init_Xi2_system(393) > Done
05-22 03:25:12.094+0900 I/efl-extension( 4441): efl_extension_rotary.c: eext_rotary_object_event_callback_add(163) > In
05-22 03:25:12.094+0900 E/efl-extension( 4441): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb9167b80, elm_image, _activated_obj : 0x0, activated : 1
05-22 03:25:12.094+0900 E/EFL     ( 4441): elementary<4441> elm_layout.c:833 _elm_layout_smart_content_set() could not swallow 0xb91277d0 into part 'genlist'
05-22 03:25:12.094+0900 E/EFL     ( 4441): elementary<4441> elc_popup.c:1734 _elm_popup_smart_content_set() The part name is invalid! : popup=0xb8fecbd8
05-22 03:25:12.134+0900 W/CRASH_MANAGER( 4288): worker.c: worker_job(1189) > 1104441737465146385511
