S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:37

Crash Information
Process Name: stemwatch
PID: 4469
Date: 2016-05-22 20:39:58+0900
Executable File Path: /opt/usr/apps/org.example.stemwatch/bin/stemwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = (nil)

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0x00000000
ebp = 0xbff4bd78, esp = 0xbff4bce0
eax = 0xb85f4f58, ebx = 0xb45a214c
ecx = 0x00000168, edx = 0x00000000
eip = 0xb45a0d78

Memory Information
MemTotal:      124 KB
MemFree:        34 KB
Buffers:         4 KB
Cached:     240232 KB
VmPeak:      89812 KB
VmSize:      89812 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       16724 KB
VmRSS:       16724 KB
VmData:      29376 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32116 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 4469 TID = 4469
4469 4471 4477 

Maps Information
b2c14000 b2c15000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b34b2000 b34b4000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnu-i686-1.7.99/module.so
b34b5000 b34d9000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b36fa000 b3708000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b3709000 b370c000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnu-i686-1.7.99/module.so
b370d000 b3710000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b3f15000 b3f18000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3f19000 b3f22000 r-xp /usr/lib/libtbm.so.1.0.0
b3f23000 b3f29000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3f2a000 b3f35000 r-xp /usr/lib/libdrm.so.2.4.0
b3f36000 b3f68000 r-xp /usr/lib/libsystemd.so.0.0.1
b3f6b000 b3f73000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3f74000 b3f8e000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b3f8f000 b3faf000 r-xp /usr/lib/libwidget_service.so.1.0.0
b3fb0000 b3fcc000 r-xp /usr/lib/libcom-core.so.0.0.1
b3fcd000 b4111000 r-xp /usr/lib/libcairo.so.2.11200.14
b4115000 b4124000 r-xp /usr/lib/libwidget.so.1.0.0
b4125000 b4131000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b4132000 b4145000 r-xp /usr/lib/libalarm.so.0.0.0
b4147000 b4168000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4169000 b4172000 r-xp /usr/lib/libappcore-watch.so.1.1
b4173000 b417e000 r-xp /lib/libnss_files-2.13.so
b43bf000 b43e6000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b43e7000 b440c000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b440d000 b452e000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b453e000 b4574000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4576000 b4579000 r-xp /usr/lib/libiniparser.so.0
b457b000 b4586000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b4587000 b4590000 r-xp /usr/lib/libappsvc.so.0.1.0
b4591000 b4594000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4597000 b459a000 r-xp /usr/lib/libdri2.so.0.0.0
b459b000 b459d000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b459e000 b45a2000 r-xp /opt/usr/apps/org.example.stemwatch/bin/stemwatch
b45a3000 b45a9000 r-xp /usr/lib/libogg.so.0.7.1
b45aa000 b45d5000 r-xp /usr/lib/libvorbis.so.0.4.3
b45d6000 b46c1000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b46cf000 b46d1000 r-xp /usr/lib/libXau.so.6.0.0
b46d2000 b4732000 r-xp /usr/lib/libssl.so.1.0.0
b4737000 b4768000 r-xp /usr/lib/libidn.so.11.5.44
b4769000 b4779000 r-xp /usr/lib/libcares.so.2.1.0
b477a000 b47e3000 r-xp /usr/lib/libsndfile.so.1.0.25
b47e9000 b47f3000 r-xp /usr/lib/libsensord-share.so
b47f4000 b481a000 r-xp /lib/libexpat.so.1.5.2
b481c000 b4843000 r-xp /usr/lib/libpng12.so.0.50.0
b4844000 b4864000 r-xp /usr/lib/libxcb.so.1.1.0
b4865000 b48d4000 r-xp /usr/lib/libcurl.so.4.3.0
b48d6000 b48e1000 r-xp /usr/lib/libethumb.so.1.7.99
b5e41000 b5f19000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f25000 b5f28000 r-xp /usr/lib/libctxdata.so.0.0.0
b5f29000 b5f3f000 r-xp /usr/lib/libremix.so.0.0.0
b5f40000 b5f42000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f43000 b5f6f000 r-xp /usr/lib/liblua-5.1.so
b5f70000 b5f7a000 r-xp /usr/lib/libembryo.so.1.7.99
b5f7b000 b5fc1000 r-xp /usr/lib/libjpeg.so.8.0.2
b5fd2000 b5ff0000 r-xp /usr/lib/libsensor.so.1.1.0
b5ff2000 b6074000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6079000 b60ad000 r-xp /usr/lib/libfontconfig.so.1.5.0
b60af000 b610a000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b610c000 b6122000 r-xp /usr/lib/libfribidi.so.0.3.1
b6123000 b61af000 r-xp /usr/lib/libfreetype.so.6.11.3
b61b3000 b61b6000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b61b7000 b61bd000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b61be000 b61c4000 r-xp /usr/lib/libecore_fb.so.1.7.99
b61c6000 b61d7000 r-xp /usr/lib/libXext.so.6.4.0
b61d8000 b630c000 r-xp /usr/lib/libX11.so.6.3.0
b6310000 b6315000 r-xp /usr/lib/libXtst.so.6.1.0
b6316000 b631e000 r-xp /usr/lib/libXrender.so.1.3.0
b631f000 b6328000 r-xp /usr/lib/libXrandr.so.2.2.0
b6329000 b632b000 r-xp /usr/lib/libXinerama.so.1.0.0
b632c000 b633a000 r-xp /usr/lib/libXi.so.6.1.0
b633b000 b633f000 r-xp /usr/lib/libXfixes.so.3.1.0
b6340000 b6342000 r-xp /usr/lib/libXgesture.so.7.0.0
b6343000 b6345000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6346000 b6348000 r-xp /usr/lib/libXdamage.so.1.1.0
b6349000 b6352000 r-xp /usr/lib/libXcursor.so.1.0.2
b6353000 b637e000 r-xp /usr/lib/libecore_con.so.1.7.99
b6380000 b6388000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6389000 b6394000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6395000 b639b000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b639c000 b63bd000 r-xp /usr/lib/libefreet.so.1.7.99
b63bf000 b63cb000 r-xp /usr/lib/libedbus.so.1.7.99
b63cc000 b652b000 r-xp /usr/lib/libicuuc.so.51.1
b6539000 b6742000 r-xp /usr/lib/libicui18n.so.51.1
b674b000 b67e8000 r-xp /usr/lib/libedje.so.1.7.99
b67ea000 b67fb000 r-xp /usr/lib/libecore_input.so.1.7.99
b67fc000 b6803000 r-xp /usr/lib/libecore_file.so.1.7.99
b6804000 b682a000 r-xp /usr/lib/libeet.so.1.7.99
b6833000 b695b000 r-xp /usr/lib/libevas.so.1.7.99
b6978000 b69ab000 r-xp /usr/lib/libecore_evas.so.1.7.99
b69ad000 b69f1000 r-xp /usr/lib/libecore_x.so.1.7.99
b69f3000 b6bed000 r-xp /usr/lib/libelementary.so.1.7.99
b6bfe000 b6c04000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6c05000 b6c09000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6c0d000 b6c0e000 r-xp /usr/lib/libjournal.so.0.1.0
b6c0f000 b6d57000 r-xp /usr/lib/libxml2.so.2.7.8
b6d5e000 b6d71000 r-xp /lib/libresolv-2.13.so
b6d75000 b6d92000 r-xp /lib/libz.so.1.2.5
b6d93000 b6d96000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d97000 b6d9c000 r-xp /usr/lib/libffi.so.5.0.10
b6d9d000 b6d9e000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6da0000 b6da4000 r-xp /lib/libattr.so.1.1.0
b6da5000 b6fb7000 r-xp /usr/lib/libcrypto.so.1.0.0
b6fd2000 b6ff3000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6ff4000 b701c000 r-xp /lib/libm-2.13.so
b701e000 b7079000 r-xp /usr/lib/libeina.so.1.7.99
b707c000 b7087000 r-xp /usr/lib/libvconf.so.0.2.45
b7088000 b708b000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b708c000 b70da000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b70db000 b723c000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b7240000 b7247000 r-xp /lib/librt-2.13.so
b724a000 b7251000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b7253000 b726d000 r-xp /lib/libgcc_s-4.6.4.so.1
b726e000 b7276000 r-xp /lib/libcrypt-2.13.so
b729f000 b72a3000 r-xp /lib/libcap.so.2.21
b72a4000 b72a6000 r-xp /usr/lib/libiri.so
b72a8000 b72d4000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b72d5000 b72f5000 r-xp /usr/lib/libecore.so.1.7.99
b7304000 b730d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b730e000 b7431000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b7432000 b7445000 r-xp /usr/lib/libail.so.0.1.0
b7447000 b746c000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b746d000 b7477000 r-xp /lib/libunwind.so.8.0.1
b7481000 b75f2000 r-xp /lib/libc-2.13.so
b75f8000 b7642000 r-xp /usr/lib/libdbus-1.so.3.7.2
b7643000 b7648000 r-xp /usr/lib/libbundle.so.0.1.22
b7649000 b764c000 r-xp /lib/libdl-2.13.so
b764f000 b7654000 r-xp /usr/lib/libsmack.so.1.0.0
b7655000 b76fd000 r-xp /usr/lib/libsqlite3.so.0.8.6
b7700000 b771a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b771b000 b7732000 r-xp /lib/libpthread-2.13.so
b7736000 b7739000 r-xp /usr/lib/libdlog.so.0.0.0
b773a000 b774a000 r-xp /usr/lib/libaul.so.0.1.0
b774c000 b7752000 r-xp /usr/lib/libappcore-common.so.1.1
b7753000 b7758000 r-xp /usr/lib/libappcore-efl.so.1.1
b775a000 b775f000 r-xp /usr/lib/libsys-assert.so
b7762000 b7780000 r-xp /lib/ld-2.13.so
b7780000 b7781000 r-xp [vdso]
b7783000 b778a000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:4469)
Call Stack Count: 18
 0: create_popup + 0x48 (0xb45a0d78) [/opt/usr/apps/org.example.stemwatch/bin/stemwatch] + 0x2d78
 1: btn_clicked_cb + 0x3a (0xb45a0d1a) [/opt/usr/apps/org.example.stemwatch/bin/stemwatch] + 0x2d1a
 2: evas_object_smart_callback_call + 0xe2 (0xb68787d2) [/usr/lib/libevas.so.1] + 0x457d2
 3: (0xb6a5d446) [/usr/lib/libelementary.so.1] + 0x6a446
 4: (0xb67b59a0) [/usr/lib/libedje.so.1] + 0x6a9a0
 5: (0xb67bcdd2) [/usr/lib/libedje.so.1] + 0x71dd2
 6: (0xb67b6a7c) [/usr/lib/libedje.so.1] + 0x6ba7c
 7: (0xb67b6faf) [/usr/lib/libedje.so.1] + 0x6bfaf
 8: (0xb67b7164) [/usr/lib/libedje.so.1] + 0x6c164
 9: (0xb72e1f32) [/usr/lib/libecore.so.1] + 0xcf32
10: (0xb72de519) [/usr/lib/libecore.so.1] + 0x9519
11: (0xb72e347a) [/usr/lib/libecore.so.1] + 0xe47a
12: ecore_main_loop_begin + 0x3f (0xb72e39cf) [/usr/lib/libecore.so.1] + 0xe9cf
13: watch_core_main + 0x172 (0xb416cc72) [/usr/lib/libappcore-watch.so.1] + 0x3c72
14: watch_app_main + 0xd6 (0xb416e686) [/usr/lib/libappcore-watch.so.1] + 0x5686
15: main + 0x115 (0xb45a01b5) [/opt/usr/apps/org.example.stemwatch/bin/stemwatch] + 0x21b5
16: __libc_csu_init + 0x51 (0xb77865b1) [/opt/usr/apps/org.example.stemwatch/bin/stemwatch] + 0xb77865b1
17: __libc_start_main + 0xf3 (0xb749a0f3) [/lib/libc.so.6] + 0x190f3
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
st.c: __request_handler(671) > APP_GET_APPID_BYPID : 4469 : 0
05-22 20:39:55.171+0900 D/AUL     ( 2289): app_sock.c: __app_send_cmd_with_result(618) > recv result  = 30
05-22 20:39:55.171+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 51 (server: 4)
05-22 20:39:55.171+0900 D/COM_CORE( 4469): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 17 (server: -1)
05-22 20:39:55.171+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: slave_hello_sync(8418) > [SECURE_LOG] [org.example.stemwatch] Instance Count: 1
05-22 20:39:55.171+0900 D/DATA_PROVIDER_MASTER( 2289): slave_life.c: slave_set_valid(2155) > [SECURE_LOG] slave is set valid
05-22 20:39:55.171+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: slave_hello_sync(8445) > [SECURE_LOG] Slave RPC should be updated soon (waiting prepare sync)
05-22 20:39:55.171+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: slave_hello_sync(8448) > [SECURE_LOG] Slave is activated by request: 4469 (org.example.stemwatch)/(4469.5208.165863)
05-22 20:39:55.171+0900 D/DATA_PROVIDER_MASTER( 2289): instance.c: instance_watch_change_package_info(4000) > [SECURE_LOG] Package information is not touched (org.example.stemwatch)
05-22 20:39:55.171+0900 D/DATA_PROVIDER_MASTER( 2289): instance.c: instance_duplicate_packet_create(1109) > [SECURE_LOG] [TODO] Instance package info: 0xb9134b00:org.example.stemwatch
05-22 20:39:55.171+0900 D/DATA_PROVIDER_MASTER( 2289): instance.c: instance_duplicate_packet_create(1137) > [SECURE_LOG] [TODO] Instance request_state is not touched
05-22 20:39:55.171+0900 D/DATA_PROVIDER_MASTER( 2289): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
05-22 20:39:55.171+0900 D/COM_CORE( 4469): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2289, fd: -1
05-22 20:39:55.171+0900 D/COM_CORE( 4469): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 165 bytes (pid: 2289), fd: -1
05-22 20:39:55.171+0900 D/COM_CORE( 4469): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
05-22 20:39:55.171+0900 D/WIDGET_PROVIDER_APP( 4469): client.c: method_new(475) > [SECURE_LOG] Create: pkgname[org.example.stemwatch], id[file:///opt/usr/share/live_magazine/org.example.stemwatch_2260_5207.816895.png], content[], timeout[10], has_script[0], period[0.000000], cluster[user,created], category[default], skip[1], abi[app], size: 360x360, ori: 0
05-22 20:39:55.171+0900 D/WATCH_CORE( 4469): appcore-watch.c: __widget_create(870) > widget_create
05-22 20:39:55.171+0900 W/CAPI_WATCH_APPLICATION( 4469): watch_app_main.c: _watch_core_create(205) > _watch_core_create
05-22 20:39:55.171+0900 D/WIDGET  ( 4469): binder.c: load_ecore_evas_function(98) > [SECURE_LOG] pixmap_allocfunc_new is not found
05-22 20:39:55.171+0900 D/WIDGET  ( 4469): binder.c: load_ecore_evas_function(103) > [SECURE_LOG] allocfunc_with_stirde_new is not found
05-22 20:39:55.171+0900 D/WIDGET_PROVIDER( 4469): widget_provider_buffer.c: widget_provider_buffer_create(2015) > [SECURE_LOG] acquire_buffer: [WIDGET] file:///opt/usr/share/live_magazine/org.example.stemwatch_2260_5207.816895.png, handler: 0xb411c4d0
05-22 20:39:55.171+0900 D/WIDGET  ( 4469): binder.c: binder_ecore_evas_new(522) > [SECURE_LOG] Preferred engine: (null) (opengl or opengl_x11)
05-22 20:39:55.171+0900 D/WIDGET_PROVIDER( 4469): widget_provider_buffer.c: widget_provider_buffer_acquire(2087) > [SECURE_LOG] acquire_buffer: [WIDGET] file:///opt/usr/share/live_magazine/org.example.stemwatch_2260_5207.816895.png, 1x1, size: 4, handler: 0xb411c4d0
05-22 20:39:55.181+0900 E/COM_CORE( 2289): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
05-22 20:39:55.181+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (56)
05-22 20:39:55.181+0900 D/COM_CORE( 2289): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [61] New TCB created: R(62), W(63)
05-22 20:39:55.181+0900 D/COM_CORE( 2289): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
05-22 20:39:55.181+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 61 (server: 4)
05-22 20:39:55.181+0900 D/COM_CORE( 2289): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
05-22 20:39:55.181+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
05-22 20:39:55.181+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
05-22 20:39:55.181+0900 D/COM_CORE( 2289): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(56) for pid(-1)
05-22 20:39:55.181+0900 E/COM_CORE( 2289): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
05-22 20:39:55.181+0900 D/AUL_AMD ( 2161): amd_request.c: __request_handler(495) > __request_handler: 15
05-22 20:39:55.181+0900 D/AUL_AMD ( 2161): amd_status.c: _status_get_appid_bypid(432) > [SECURE_LOG] appid for 4469 is org.example.stemwatch
05-22 20:39:55.181+0900 D/AUL_AMD ( 2161): amd_request.c: __request_handler(671) > APP_GET_APPID_BYPID : 4469 : 0
05-22 20:39:55.181+0900 D/AUL     ( 2289): app_sock.c: __app_send_cmd_with_result(618) > recv result  = 30
05-22 20:39:55.181+0900 D/DATA_PROVIDER_MASTER( 2289): server.c: slave_hello_sync_prepare(8168) > [SECURE_LOG] Update handle for org.example.stemwatch (51)
05-22 20:39:55.181+0900 D/DATA_PROVIDER_MASTER( 2289): slave_rpc.c: slave_rpc_update_handle(518) > [SECURE_LOG] SLAVE: New handle assigned for 4469, 51
05-22 20:39:55.181+0900 D/DATA_PROVIDER_MASTER( 2289): package.c: slave_activated_cb(169) > [SECURE_LOG] Watch instance: 1
05-22 20:39:55.181+0900 D/DATA_PROVIDER_MASTER( 2289): package.c: slave_activated_cb(182) > [SECURE_LOG] Recover state for 1 instances of org.example.stemwatch
05-22 20:39:55.181+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: buffer_handler_resize(1047) > [SECURE_LOG] Buffer size is updated[1x1]
05-22 20:39:55.181+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: load_pixmap_buffer(539) > [SECURE_LOG] Loaded pixmap(info->id): pixmap://14680114:4
05-22 20:39:55.181+0900 D/COM_CORE( 4469): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2289, fd: -1
05-22 20:39:55.181+0900 D/COM_CORE( 4469): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 24 bytes (pid: 2289), fd: -1
05-22 20:39:55.181+0900 D/COM_CORE( 4469): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
05-22 20:39:55.181+0900 D/WIDGET_PROVIDER( 4469): fb.c: fb_create(610) > [SECURE_LOG] PIXMAP: 14680114
05-22 20:39:55.181+0900 D/WIDGET_PROVIDER( 4469): widget_provider_buffer.c: send_acquire_request(148) > [SECURE_LOG] type: 0x0, name: 4469.5208.165863, pkgname[org.example.stemwatch], id[file:///opt/usr/share/live_magazine/org.example.stemwatch_2260_5207.816895.png], w[1], h[1], size[4], buffer_id[pixmap://14680114:4], fb[0xb856fe78]
05-22 20:39:55.181+0900 D/WIDGET_PROVIDER( 4469): fb.c: create_gem(509) > [SECURE_LOG] dri2_buffer: 0xb85fb750, name: 0xe, 1x1 (1x1), pitch: 4, buf_count: 1, gem: 0xb856fca8
05-22 20:39:55.181+0900 D/WIDGET  ( 4469): binder.c: alloc_fb(430) > [SECURE_LOG] HW Accelerated buffer is created 0xb85c9c28, (1x1)
05-22 20:39:55.181+0900 E/COM_CORE( 2289): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
05-22 20:39:55.181+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (61)
05-22 20:39:55.181+0900 D/COM_CORE( 2289): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
05-22 20:39:55.181+0900 D/COM_CORE( 2289): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
05-22 20:39:55.181+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
05-22 20:39:55.181+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
05-22 20:39:55.181+0900 D/COM_CORE( 2289): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(61) for pid(-1)
05-22 20:39:55.181+0900 E/COM_CORE( 2289): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
05-22 20:39:55.191+0900 D/WIDGET  ( 4469): binder.c: load_update_function(128) > [SECURE_LOG] App detected
05-22 20:39:55.191+0900 D/WIDGET_PROVIDER( 4469): fb.c: destroy_gem(524) > [SECURE_LOG] unref pixmap bo
05-22 20:39:55.191+0900 D/WIDGET  ( 4469): binder.c: free_fb(481) > [SECURE_LOG] HW Accelerated buffer is destroyed
05-22 20:39:55.191+0900 D/COM_CORE( 2289): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [56] New TCB created: R(57), W(58)
05-22 20:39:55.191+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 56 (server: 4)
05-22 20:39:55.191+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: destroy_pixmap(343) > [SECURE_LOG] pixmap 14680114
05-22 20:39:55.191+0900 D/COM_CORE( 4469): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2289, fd: -1
05-22 20:39:55.191+0900 D/COM_CORE( 4469): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 4 bytes (pid: 2289), fd: -1
05-22 20:39:55.191+0900 D/COM_CORE( 4469): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
05-22 20:39:55.191+0900 D/WIDGET  ( 4469): widget.c: widget_viewer_release_buffer(609) > [SECURE_LOG] Release buffer: -1 (0)
05-22 20:39:55.191+0900 D/WIDGET  ( 4469): binder.c: alloc_fb(409) > [SECURE_LOG] Size of ee is updated: 360x360 (info: 0xb85c9c28)
05-22 20:39:55.191+0900 D/WIDGET_PROVIDER( 4469): widget_provider_buffer.c: widget_provider_buffer_acquire(2087) > [SECURE_LOG] acquire_buffer: [WIDGET] file:///opt/usr/share/live_magazine/org.example.stemwatch_2260_5207.816895.png, 360x360, size: 4, handler: 0xb411c4d0
05-22 20:39:55.191+0900 D/COM_CORE( 2289): com-core_thread.c: tcb_create(564) > [SECURE_LOG] [61] New TCB created: R(62), W(63)
05-22 20:39:55.191+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(350) > [SECURE_LOG] Thread is created for 61 (server: 4)
05-22 20:39:55.191+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: buffer_handler_resize(1047) > [SECURE_LOG] Buffer size is updated[360x360]
05-22 20:39:55.191+0900 D/DATA_PROVIDER_MASTER( 2289): buffer_handler.c: load_pixmap_buffer(539) > [SECURE_LOG] Loaded pixmap(info->id): pixmap://14680116:4
05-22 20:39:55.191+0900 D/COM_CORE( 4469): com-core_packet.c: com_core_packet_oneshot_send(655) > [SECURE_LOG] Recv'd size: 60 (header: 60) pid: 2289, fd: -1
05-22 20:39:55.191+0900 D/COM_CORE( 4469): com-core_packet.c: com_core_packet_oneshot_send(701) > [SECURE_LOG] Recv'd 24 bytes (pid: 2289), fd: -1
05-22 20:39:55.191+0900 D/COM_CORE( 4469): com-core_packet.c: com_core_packet_oneshot_send(718) > [SECURE_LOG] Close connection: 23 (recv_fd: -1)
05-22 20:39:55.191+0900 D/WIDGET_PROVIDER( 4469): fb.c: fb_create(610) > [SECURE_LOG] PIXMAP: 14680116
05-22 20:39:55.191+0900 D/WIDGET_PROVIDER( 4469): widget_provider_buffer.c: send_acquire_request(148) > [SECURE_LOG] type: 0x0, name: 4469.5208.165863, pkgname[org.example.stemwatch], id[file:///opt/usr/share/live_magazine/org.example.stemwatch_2260_5207.816895.png], w[360], h[360], size[4], buffer_id[pixmap://14680116:4], fb[0xb856fca8]
05-22 20:39:55.191+0900 D/WIDGET_PROVIDER( 4469): fb.c: create_gem(509) > [SECURE_LOG] dri2_buffer: 0xb85f6480, name: 0xe, 360x360 (360x360), pitch: 1440, buf_count: 1, gem: 0xb85fb768
05-22 20:39:55.191+0900 D/WIDGET  ( 4469): binder.c: alloc_fb(430) > [SECURE_LOG] HW Accelerated buffer is created 0xb85c9c28, (360x360)
05-22 20:39:55.201+0900 E/COM_CORE( 2289): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
05-22 20:39:55.201+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (61)
05-22 20:39:55.201+0900 D/COM_CORE( 2289): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
05-22 20:39:55.201+0900 D/COM_CORE( 2289): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
05-22 20:39:55.201+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
05-22 20:39:55.201+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
05-22 20:39:55.201+0900 D/COM_CORE( 2289): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(61) for pid(-1)
05-22 20:39:55.201+0900 E/COM_CORE( 2289): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
05-22 20:39:55.221+0900 E/COM_CORE( 2289): com-core_thread.c: client_cb(397) > [SECURE_LOG] Available data: 0
05-22 20:39:55.221+0900 D/COM_CORE( 2289): com-core_thread.c: client_cb(433) > [SECURE_LOG] Client CB is terminated (56)
05-22 20:39:55.221+0900 D/COM_CORE( 2289): com-core_thread.c: com_core_thread_recv_with_fd(1103) > [SECURE_LOG] Disconnected
05-22 20:39:55.221+0900 D/COM_CORE( 2289): com-core_packet.c: service_cb(460) > [SECURE_LOG] ZERO bytes receives(1)
05-22 20:39:55.221+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(498) > [SECURE_LOG] Service callback returns -104 < 0
05-22 20:39:55.221+0900 D/COM_CORE( 2289): com-core_thread.c: evt_pipe_cb(505) > [SECURE_LOG] Disconnecting
05-22 20:39:55.221+0900 D/COM_CORE( 2289): com-core_packet.c: client_disconnected_cb(361) > [SECURE_LOG] Clean up all requests and a receive context for handle(56) for pid(-1)
05-22 20:39:55.221+0900 E/COM_CORE( 2289): com-core_thread.c: terminate_thread(192) > [SECURE_LOG] Thread returns: -104
05-22 20:39:55.291+0900 E/EFL     ( 4469): eina_module<4469> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
05-22 20:39:55.311+0900 D/WIDGET_VIEWER( 2260): client.c: master_update_id(1650) > [SECURE_LOG] Update ID(file:///opt/usr/share/live_magazine/org.example.stemwatch_2260_5207.816895.png) for 5207.816895
05-22 20:39:55.381+0900 D/W-SETTING( 2716): setting_data_vconf.c: unregister_vconf_changing(27) > [unregister_vconf_changing : 27] Setting - vconf's changed callback unregisted!!
05-22 20:39:55.381+0900 D/W-SETTING( 2716): setting_data_vconf.c: unregister_vconf_changing(29) > [unregister_vconf_changing : 29] Setting - vconf's changed callback do not unregist
05-22 20:39:55.381+0900 D/W-SETTING( 2716): setting_data_vconf.c: unregister_vconf_changing(27) > [unregister_vconf_changing : 27] Setting - vconf's changed callback unregisted!!
05-22 20:39:55.411+0900 D/WATCH_CORE( 4469): appcore-watch.c: __widget_create(888) > widget_create done
05-22 20:39:55.411+0900 D/ALARM_MANAGER( 4469): alarm-lib.c: alarmmgr_init(326) > [SECURE_LOG] Enter
05-22 20:39:55.441+0900 E/WIDGET_VIEWER( 2260): client.c: master_created(1711) > [SECURE_LOG] [5207.816895] pkgname: org.example.stemwatch, id: file:///opt/usr/share/live_magazine/org.example.stemwatch_2260_5207.816895.png, content: , gbar_w: 0, gbar_h: 0, widget_w: 360, widget_h: 360, cluster: user,created, category: default, widget_fname: "pixmap://0:0", gbar_fname: "", auto_launch: , priority: 0.000000, size_list: 4, user: 1, pinup: 0, widget_type: 4, gbar_type: 0, period: 0.000000, title: [], is_pinned_up: 0
05-22 20:39:55.441+0900 D/WIDGET_VIEWER( 2260): fb.c: fb_create(376) > [SECURE_LOG] PIXMAP-SHMID: 0 is gotten (0)
05-22 20:39:55.441+0900 D/WIDGET_VIEWER( 2260): widget.c: widget_viewer_set_visibility(3860) > [SECURE_LOG] org.example.stemwatch has no changes
05-22 20:39:55.441+0900 D/WIDGET_EVAS( 2260): widget_viewer_evas.c: __widget_created_cb(4977) > [SECURE_LOG] Invoke raw create org.example.stemwatch
05-22 20:39:55.441+0900 D/WIDGET_VIEWER( 2260): widget.c: _widget_set_visibility(1143) > [SECURE_LOG] [org.example.stemwatch] visibility is changed 0x[0]
05-22 20:39:55.441+0900 D/WIDGET_EVAS( 2260): widget_viewer_evas.c: widget_unref(956) > [SECURE_LOG] refcnt: 1 (org.example.stemwatch)
05-22 20:39:55.491+0900 D/ALARM_MANAGER( 4469): alarm-lib.c: __sub_init(312) > [SECURE_LOG] alarm_context.pid is set to processID, 4469.
05-22 20:39:55.491+0900 D/ALARM_MANAGER( 4469): alarm-lib.c: alarmmgr_init(369) > [SECURE_LOG] [alarm-lib]: dbus own name: ALARM.aorg.aexample.astemwatch
05-22 20:39:55.491+0900 D/ALARM_MANAGER( 4469): alarm-lib.c: alarmmgr_init(397) > [SECURE_LOG] Leave
05-22 20:39:55.491+0900 E/WIDGET_PROVIDER( 4469): widget_provider.c: widget_provider_send_hello_sync(1600) > [SECURE_LOG] #widget_create return [0]
05-22 20:39:55.491+0900 D/WIDGET_PROVIDER( 4469): widget_provider.c: initialize_provider(1260) > [SECURE_LOG] Slave is initialized
05-22 20:39:55.491+0900 E/WIDGET_PROVIDER_APP( 4469): client.c: client_init_sync(1342) > [SECURE_LOG] widget_provider_init return [0]
05-22 20:39:55.491+0900 D/WATCH_CORE( 4469): appcore-watch.c: __watch_core_widget_init(1014) > succeded to initialize the widget
05-22 20:39:55.491+0900 D/WATCH_CORE( 4469): appcore-watch-signal.c: _watch_core_listen_alpm_handler(141) > watch_core_listen_deviced_alpm
05-22 20:39:55.511+0900 E/WIDGET_VIEWER( 2260): fb.c: fb_is_created(425) > [SECURE_LOG] access: 11 ((null))
05-22 20:39:55.511+0900 D/WIDGET_VIEWER( 2260): widget.c: widget_viewer_get_size_type(2679) > [SECURE_LOG] FB is not created yet, but give its size to the caller: 360x360
05-22 20:39:55.511+0900 D/DATA_PROVIDER_MASTER( 2289): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
05-22 20:39:55.551+0900 D/WATCH_CORE( 4469): appcore-watch.c: __do_app(273) > appcontrol request
05-22 20:39:55.551+0900 D/WATCH_CORE( 4469): appcore-watch.c: __do_app(288) > widget is initialized
05-22 20:39:55.551+0900 W/CAPI_WATCH_APPLICATION( 4469): watch_app_main.c: _watch_core_control(228) > _watch_core_control
05-22 20:39:55.581+0900 D/WIDGET_VIEWER( 2260): fb.c: fb_create(376) > [SECURE_LOG] PIXMAP-SHMID: 14680114 is gotten (4)
05-22 20:39:55.581+0900 D/WIDGET_EVAS( 2260): widget_viewer_evas.c: __widget_event_widget_size_changed(6207) > [SECURE_LOG] widget LB size is changed
05-22 20:39:55.791+0900 E/WIDGET_VIEWER( 2260): widget.c: widget_viewer_get_size_type(2687) > [SECURE_LOG] widget_service_get_size_type failed : -22
05-22 20:39:55.791+0900 E/WIDGET_EVAS( 2260): widget_viewer_evas.c: __widget_event_widget_updated(5824) > [SECURE_LOG] Size is not valid FFFF
05-22 20:39:55.861+0900 D/WIDGET_VIEWER( 2260): fb.c: fb_create(376) > [SECURE_LOG] PIXMAP-SHMID: 14680116 is gotten (4)
05-22 20:39:55.861+0900 D/WIDGET_EVAS( 2260): widget_viewer_evas.c: __widget_event_widget_size_changed(6207) > [SECURE_LOG] widget LB size is changed
05-22 20:39:56.091+0900 D/AUL_AMD ( 2161): amd_launch.c: __grab_timeout_handler(1212) > pid(4469) ecore_x_pointer_ungrab
05-22 20:39:56.091+0900 D/AUL_AMD ( 2161): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.example.stemwatch /opt/usr/apps/org.example.stemwatch/bin/stemwatch
05-22 20:39:56.091+0900 D/RUA     ( 2161): rua.c: rua_add_history(179) > rua_add_history start
05-22 20:39:56.091+0900 D/RUA     ( 2161): rua.c: rua_add_history(247) > rua_add_history ok
05-22 20:39:56.131+0900 D/WIDGET_EVAS( 2260): widget_viewer_evas.c: __widget_update_pixmap_object(4798) > [SECURE_LOG] Pixmap is not acquired
05-22 20:39:56.271+0900 D/WIDGET_EVAS( 2260): widget_viewer_evas.c: acquire_widget_pixmap_cb(4751) > [SECURE_LOG] fillset: 360x360
05-22 20:39:56.271+0900 D/WIDGET_EVAS( 2260): widget_viewer_evas.c: widget_unref(956) > [SECURE_LOG] refcnt: 1 (org.example.stemwatch)
05-22 20:39:56.941+0900 E/EFL     ( 2716): ecore<2716> ecore.c:568 _ecore_magic_fail() 
05-22 20:39:56.941+0900 E/EFL     ( 2716): *** ECORE ERROR: Ecore Magic Check Failed!!!
05-22 20:39:56.941+0900 E/EFL     ( 2716): *** IN FUNCTION: ecore_timer_del()
05-22 20:39:56.941+0900 E/EFL     ( 2716): ecore<2716> ecore.c:572 _ecore_magic_fail()   Input handle has already been freed!
05-22 20:39:56.941+0900 E/EFL     ( 2716): ecore<2716> ecore.c:581 _ecore_magic_fail() *** NAUGHTY PROGRAMMER!!!
05-22 20:39:56.941+0900 E/EFL     ( 2716): *** SPANK SPANK SPANK!!!
05-22 20:39:56.941+0900 E/EFL     ( 2716): *** Now go fix your code. Tut tut tut!
05-22 20:39:56.941+0900 D/RESOURCED( 2364): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2260, type = 0
05-22 20:39:56.941+0900 D/RESOURCED( 2364): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 2260
05-22 20:39:56.941+0900 D/RESOURCED( 2364): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2260, appname = (null)
05-22 20:39:56.941+0900 D/RESOURCED( 2364): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2260
05-22 20:39:56.941+0900 D/AUL_AMD ( 2161): amd_launch.c: __e17_status_handler(1911) > pid(2260) status(3)
05-22 20:39:56.981+0900 D/APP_CORE( 2716): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1c00002 fully_obscured 1
05-22 20:39:56.981+0900 D/APP_CORE( 2716): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
05-22 20:39:56.981+0900 D/APP_CORE( 2716): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
05-22 20:39:56.981+0900 D/APP_CORE( 2716): appcore-efl.c: __do_app(470) > [APP 2716] Event: PAUSE State: RUNNING
05-22 20:39:56.981+0900 D/APP_CORE( 2716): appcore-efl.c: __do_app(538) > [APP 2716] PAUSE
05-22 20:39:56.981+0900 I/CAPI_APPFW_APPLICATION( 2716): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
05-22 20:39:56.981+0900 D/W-SETTING( 2716): setting.c: app_pause(1270) > [app_pause : 1270] Setting - app_pause()
05-22 20:39:56.981+0900 D/APP_CORE( 2716): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
05-22 20:39:56.981+0900 E/APP_CORE( 2716): appcore-efl.c: __trm_app_info_send_socket(233) > access
05-22 20:39:57.001+0900 D/RESOURCED( 2364): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2716, type = 2
05-22 20:39:57.001+0900 D/RESOURCED( 2364): cpu.c: cpu_background_state(100) > [cpu_background_state,100] cpu_background_state : pid = 2716, appname = clocksetting
05-22 20:39:57.001+0900 D/RESOURCED( 2364): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/service/cgroup.procs, value 2716
05-22 20:39:57.001+0900 I/RESOURCED( 2364): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/background/cgroup.procs, pid : 2716, oom : 300
05-22 20:39:57.001+0900 E/RESOURCED( 2364): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/background/cgroup.procs open failed
05-22 20:39:57.031+0900 E/W_HOME  ( 2260): main.c: _window_focus_in_cb(851) > win[25165827], ev->win[25165831]
05-22 20:39:57.031+0900 D/APPS    ( 2260): apps_main.c: _window_focus_in_cb(288) >  focus in
05-22 20:39:57.031+0900 E/W_HOME  ( 2260): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
05-22 20:39:57.031+0900 D/APPS    ( 2260): apps_main.c: apps_main_resume(693) >  Resume starts
05-22 20:39:57.031+0900 D/APPS    ( 2260): scroller.c: _resume_result_cb(187) >  Activate the rotary events for apps
05-22 20:39:57.031+0900 E/efl-extension( 2260): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb8772000, elm_scroller, _activated_obj : 0xb8772000, activated : 1
05-22 20:39:57.031+0900 D/APP_CORE( 2260): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1800007 fully_obscured 0
05-22 20:39:57.031+0900 D/APP_CORE( 2260): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 0
05-22 20:39:57.031+0900 D/APP_CORE( 2260): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
05-22 20:39:57.031+0900 D/APP_CORE( 2260): appcore-efl.c: __do_app(470) > [APP 2260] Event: RESUME State: PAUSED
05-22 20:39:57.031+0900 D/LAUNCH  ( 2260): appcore-efl.c: __do_app(557) > [w-home:Application:resume:start]
05-22 20:39:57.031+0900 D/APP_CORE( 2260): appcore-efl.c: __do_app(559) > [APP 2260] RESUME
05-22 20:39:57.031+0900 I/CAPI_APPFW_APPLICATION( 2260): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
05-22 20:39:57.031+0900 D/W_HOME  ( 2260): main.c: _resume_cb(564) > Resumed
05-22 20:39:57.031+0900 D/APPS    ( 2260): apps_main.c: apps_main_is_visible(757) >  bShow:[1]
05-22 20:39:57.031+0900 E/W_HOME  ( 2260): main.c: _resume_cb(576) > Apps is showing
05-22 20:39:57.031+0900 D/LAUNCH  ( 2260): appcore-efl.c: __do_app(567) > [w-home:Application:resume:done]
05-22 20:39:57.031+0900 D/LAUNCH  ( 2260): appcore-efl.c: __do_app(569) > [w-home:Application:Launching:done]
05-22 20:39:57.031+0900 D/APP_CORE( 2260): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
05-22 20:39:57.031+0900 E/APP_CORE( 2260): appcore-efl.c: __trm_app_info_send_socket(233) > access
05-22 20:39:57.311+0900 E/W_HOME  ( 2260): clock_service.c: _del_waiting_timer(303) > clock waiting timer is deleted
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): clock_inf_widget.c: _create(427) > Prepared clock found (org.example.stemwatch)
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): clock_inf_widget.c: _create(481) > Create clock: org.example.stemwatch
05-22 20:39:57.311+0900 D/WIDGET_VIEWER( 2260): widget.c: widget_viewer_set_visibility(3860) > [SECURE_LOG] org.example.stemwatch has no changes
05-22 20:39:57.311+0900 D/WIDGET_VIEWER( 2260): widget.c: widget_viewer_set_visibility(3860) > [SECURE_LOG] org.example.stemwatch has no changes
05-22 20:39:57.311+0900 E/W_HOME  ( 2260): clock_shortcut.c: _shortcut_layout_destroy(401) > (obj == NULL) -> _shortcut_layout_destroy() return
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): clock_shortcut.c: _shortcut_layout_create(371) > 
05-22 20:39:57.311+0900 D/WIDGET_VIEWER( 2260): widget.c: widget_viewer_set_visibility(3860) > [SECURE_LOG] org.example.stemwatch has no changes
05-22 20:39:57.311+0900 E/W_HOME  ( 2260): clock_shortcut.c: _mp_state_get(170) > Failed to get MUSIC_PLAYER_VCONF_STATE
05-22 20:39:57.311+0900 E/W_HOME  ( 2260): clock_shortcut.c: _list_lastest_info_get(94) > (s_info.list == NULL) -> _list_lastest_info_get() return
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): clock_view_indicator.c: _view_modem_icon_type_get(123) > sap:0x20 modem:0x40
05-22 20:39:57.311+0900 E/W_HOME  ( 2260): clock_view_indicator.c: _view_type_get(63) > (view == NULL) -> _view_type_get() return
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): clock_view_indicator.c: _view_dnd_icon_type_get(244) > dnd:0x80
05-22 20:39:57.311+0900 E/W_HOME  ( 2260): clock_view_indicator.c: _view_type_get(63) > (view == NULL) -> _view_type_get() return
05-22 20:39:57.311+0900 E/W_HOME  ( 2260): clock_view_indicator.c: _view_type_get(63) > (view == NULL) -> _view_type_get() return
05-22 20:39:57.311+0900 E/W_HOME  ( 2260): clock_view_indicator.c: _view_type_get(63) > (view == NULL) -> _view_type_get() return
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): clock_view_indicator.c: _view_create_by_type(260) > 3
05-22 20:39:57.311+0900 E/W_HOME  ( 2260): clock_view_indicator.c: _view_type_set(56) > (view == NULL) -> _view_type_set() return
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): clock_view_indicator.c: clock_view_indicator_event_handler(352) > 0xb88d7248 400000
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): clock_view_indicator.c: _view_modem_icon_type_get(123) > sap:0x20 modem:0x40
05-22 20:39:57.311+0900 E/W_HOME  ( 2260): clock_view_indicator.c: _view_type_get(63) > (view == NULL) -> _view_type_get() return
05-22 20:39:57.311+0900 E/W_HOME  ( 2260): clock_view_indicator.c: _view_type_get(63) > (view == NULL) -> _view_type_get() return
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): scroller.c: _elm_box_pack_after(313) > pack_after a page(0xb88d7248) after a page(0xb89184d8) into the scroller(0xb86f7b30), origin_reverse(0)
05-22 20:39:57.311+0900 D/WIDGET_VIEWER( 2260): widget.c: _widget_set_visibility(1143) > [SECURE_LOG] [org.example.stemwatch] visibility is changed 0x[2]
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): clock_view.c: _mouse_move_cb(343) > clock page:0xb88d7248 visibility changed:hide
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): page.c: _move_cb(65) > Page(0xb88d7248) is appended into the scroller (360:0:0:0)
05-22 20:39:57.311+0900 D/WIDGET_VIEWER( 2260): widget.c: _widget_set_visibility(1143) > [SECURE_LOG] [org.example.stemwatch] visibility is changed 0x[0]
05-22 20:39:57.311+0900 D/WIDGET_VIEWER( 2260): widget.c: _widget_set_visibility(1143) > [SECURE_LOG] [org.example.stemwatch] visibility is changed 0x[2]
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): scroller.c: _elm_box_unpack(369) > unpack a page(0xb89184d8) from the scroller(0xb86f7b30), origin_reverse(0)
05-22 20:39:57.311+0900 D/WIDGET_VIEWER( 2260): widget.c: _widget_set_visibility(1143) > [SECURE_LOG] [org.example.stemwatch] visibility is changed 0x[0]
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): clock_view.c: _mouse_move_cb(343) > clock page:0xb88d7248 visibility changed:show
05-22 20:39:57.311+0900 W/W_HOME  ( 2260): clock_manager.c: clock_manager_clock_set(260) > attached clock isn't cleaned-up, yet
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): clock_manager.c: clock_manager_clock_set(265) > attached clock:org.example.stemwatch(0)
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): clock_service.c: _clock_destroy(184) > destroying clock:org.tizen.idle-clock-digital
05-22 20:39:57.311+0900 D/AUL     ( 2260): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.tizen.windicator
05-22 20:39:57.311+0900 D/AUL     ( 2260): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(0)
05-22 20:39:57.311+0900 D/AUL_AMD ( 2161): amd_request.c: __request_handler(495) > __request_handler: 0
05-22 20:39:57.311+0900 E/AUL_AMD ( 2161): amd_request.c: __request_handler(515) > no appinfo
05-22 20:39:57.311+0900 D/AUL     ( 2260): launch.c: app_request_to_launchpad(295) > launch request result : -1
05-22 20:39:57.311+0900 D/W_HOME  ( 2260): clock_view.c: clock_view_indicator_show(106) > aul_launch_app: org.tizen.windicator(-1)
05-22 20:39:57.311+0900 D/AUL     ( 2260): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : 4407
05-22 20:39:57.311+0900 D/AUL     ( 2260): app_sock.c: __app_send_raw(265) > pid(-2) : cmd(4)
05-22 20:39:57.311+0900 D/AUL_AMD ( 2161): amd_request.c: __request_handler(495) > __request_handler: 4
05-22 20:39:57.311+0900 D/RESOURCED( 2364): proc-noti.c: recv_str(87) > [recv_str,87] str is null
05-22 20:39:57.311+0900 D/RESOURCED( 2364): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2161
05-22 20:39:57.311+0900 D/RESOURCED( 2364): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid (null), pid 4407, type 6 
05-22 20:39:57.311+0900 D/RESOURCED( 2364): proc-main.c: proc_remove_process_list(363) > [proc_remove_process_list,363] found_pid 4407
05-22 20:39:57.311+0900 D/AUL_AMD ( 2161): amd_request.c: __app_process_by_pid(179) > __app_process_by_pid, cmd: 4, pid: 4407, 
05-22 20:39:57.311+0900 D/AUL     ( 2161): app_sock.c: __app_send_raw_with_delay_reply(435) > pid(4407) : cmd(4)
05-22 20:39:57.311+0900 D/AUL_AMD ( 2161): amd_launch.c: _term_app(891) > term done
05-22 20:39:57.311+0900 D/AUL_AMD ( 2161): amd_launch.c: __set_reply_handler(873) > listen fd : 29, send fd : 28
05-22 20:39:57.311+0900 D/APP_CORE( 4407): appcore.c: __aul_handler(443) > [APP 4407]     AUL event: AUL_TERMINATE
05-22 20:39:57.311+0900 D/APP_CORE( 4407): appcore-efl.c: __do_app(470) > [APP 4407] Event: TERMINATE State: RUNNING
05-22 20:39:57.311+0900 D/APP_CORE( 4407): appcore-efl.c: __do_app(486) > [APP 4407] TERMINATE
05-22 20:39:57.311+0900 D/AUL     ( 4407): app_sock.c: __app_send_raw_with_noreply(364) > pid(-2) : cmd(22)
05-22 20:39:57.341+0900 D/AUL_AMD ( 2161): amd_request.c: __request_handler(495) > __request_handler: 22
05-22 20:39:57.341+0900 D/AUL_AMD ( 2161): amd_launch.c: __reply_handler(784) > listen fd(29) , send fd(28), pid(4407), cmd(4)
05-22 20:39:57.341+0900 D/AUL     ( 2260): launch.c: app_request_to_launchpad(295) > launch request result : 0
05-22 20:39:57.341+0900 D/W_HOME  ( 2260): clock_util.c: _app_terminate_by_pid(55) > app terminate pid:4407(ret:0)
05-22 20:39:57.341+0900 D/W_HOME  ( 2260): clock_service.c: _state_set(176) > state state waiting --> state ready 
05-22 20:39:57.341+0900 D/DATA_PROVIDER_MASTER( 2289): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
05-22 20:39:57.361+0900 D/DATA_PROVIDER_MASTER( 2289): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
05-22 20:39:57.411+0900 D/W_HOME  ( 2260): index.c: index_update(405) > Index(0xb8735c90) is clear
05-22 20:39:57.431+0900 D/W_HOME  ( 2260): index.c: _update_left(230) > page:0xb8825c10, total_inserted:0, idx_it:0xb88e4288
05-22 20:39:57.431+0900 D/W_HOME  ( 2260): index.c: _update_left(230) > page:0xb88d7248, total_inserted:-1, idx_it:0xb87d53e0
05-22 20:39:57.431+0900 D/W_HOME  ( 2260): index.c: _update_left(264) > Index(0xb8735c90-0) is updating, page(0xb88d7248-1:0)(start:0, mid:0, extra:0)
05-22 20:39:57.431+0900 D/W_HOME  ( 2260): index.c: _update_left(264) > Index(0xb8735c90-0) is updating, page(0xb8825c10-2:1)(start:0, mid:0, extra:0)
05-22 20:39:57.431+0900 D/W_HOME  ( 2260): index.c: index_update(405) > Index(0xb8771bb0) is clear
05-22 20:39:57.431+0900 D/W_HOME  ( 2260): index.c: _update_right(352) > page:0xb88d7248, total_inserted:2, idx_it:0xb87d9168
05-22 20:39:57.431+0900 D/W_HOME  ( 2260): index.c: _update_right(352) > page:0xb8825c10, total_inserted:2, idx_it:0xb8787c00
05-22 20:39:57.431+0900 D/W_HOME  ( 2260): index.c: _update_right(386) > Index(0xb8771bb0-2) is updating, page(0xb88d7248-1:0)(start:0, mid:1, extra:0)
05-22 20:39:57.431+0900 D/W_HOME  ( 2260): index.c: _update_right(386) > Index(0xb8771bb0-2) is updating, page(0xb8825c10-2:1)(start:0, mid:1, extra:0)
05-22 20:39:57.431+0900 D/W_HOME  ( 2260): scroller.c: _index_update_cb(992) > Index is updated
05-22 20:39:57.431+0900 D/DATA_PROVIDER_MASTER( 2289): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
05-22 20:39:57.441+0900 I/CAPI_APPFW_APPLICATION( 4407): app_main.c: _ui_app_appcore_terminate(581) > app_appcore_terminate
05-22 20:39:57.441+0900 D/IDLE-CLOCK-DIGITAL( 4407): main.c: _idle_clock_digital_terminate(344) > 
05-22 20:39:57.441+0900 D/MINICONTROL( 4407): minicontrol-internal.c: _minictrl_provider_proc_send(107) > [SECURE_LOG] [_minictrl_provider_proc_send : 107] _minictrl_provider_proc_send : 4407, 1
05-22 20:39:57.441+0900 D/RESOURCED( 2364): proc-monitor.c: proc_dbus_exclude_signal_handler(222) > [proc_dbus_exclude_signal_handler,222] call proc_dbus_exclude_signal_handler : pid = 4407, str = include
05-22 20:39:57.441+0900 D/DATA_PROVIDER_MASTER( 2289): monitor.c: monitor_multicast_state_change_event(198) > [SECURE_LOG] 0 events are multicasted
05-22 20:39:57.441+0900 E/MINICONTROL( 2260): minicontrol-internal-handler.c: iterate_bundleforeach(483) > [SECURE_LOG] [iterate_bundleforeach : 483] Key: __KEY_PID__ ---- Val: 4407
05-22 20:39:57.441+0900 E/MINICONTROL( 2260): 
05-22 20:39:57.441+0900 E/MINICONTROL( 2260): minicontrol-internal-handler.c: iterate_bundleforeach(473) > [SECURE_LOG] [iterate_bundleforeach : 473] Key: __KEY_CATEGORY__ ---- Val: UNKNOWN
05-22 20:39:57.441+0900 E/MINICONTROL( 2260): 
05-22 20:39:57.441+0900 E/MINICONTROL( 2260): minicontrol-internal-handler.c: iterate_bundleforeach(473) > [SECURE_LOG] [iterate_bundleforeach : 473] Key: __KEY_SERVICE_NAME__ ---- Val: idle-clock-digital
05-22 20:39:57.441+0900 E/MINICONTROL( 2260): 
05-22 20:39:57.441+0900 E/MINICONTROL( 2260): minicontrol-internal-handler.c: iterate_bundleforeach(483) > [SECURE_LOG] [iterate_bundleforeach : 483] Key: __KEY_TIMESTAMP__ ---- Val: 1463917176
05-22 20:39:57.441+0900 E/MINICONTROL( 2260): 
05-22 20:39:57.441+0900 E/MINICONTROL( 2260): minicontrol-internal-handler.c: iterate_bundleforeach(473) > [SECURE_LOG] [iterate_bundleforeach : 473] Key: __KEY_PRIORITY__ ---- Val: LV3
05-22 20:39:57.441+0900 E/MINICONTROL( 2260): 
05-22 20:39:57.441+0900 E/MINICONTROL( 2260): minicontrol-internal-handler.c: iterate_bundleforeach(483) > [SECURE_LOG] [iterate_bundleforeach : 483] Key: __KEY_STATE__ ---- Val: 1
05-22 20:39:57.441+0900 E/MINICONTROL( 2260): 
05-22 20:39:57.441+0900 D/W_HOME  ( 2260): minictrl.c: _minicontrol_monitor_cb(72) > Extract pid(-1) or name(idle-clock-digital) from origin name([idle-clock-digital])
05-22 20:39:57.441+0900 D/IDLE-CLOCK-DIGITAL( 4407): clock_view.c: _remove_formatters(621) > 
05-22 20:39:57.481+0900 I/AUL_PAD ( 2194): sigchild.h: __launchpad_sig_child(142) > dead_pid = 4407 pgid = 4407
05-22 20:39:57.481+0900 I/AUL_PAD ( 2194): sigchild.h: __sigchild_action(123) > dead_pid(4407)
05-22 20:39:57.481+0900 D/AUL_PAD ( 2194): sigchild.h: __send_app_dead_signal(81) > send dead signal done
05-22 20:39:57.481+0900 I/AUL_PAD ( 2194): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
05-22 20:39:57.481+0900 I/AUL_PAD ( 2194): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
05-22 20:39:57.481+0900 D/W_HOME  ( 2260): main.c: _dead_cb(542) > PID(4407) is dead
05-22 20:39:57.481+0900 E/W_HOME  ( 2260): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
05-22 20:39:57.481+0900 D/STARTER ( 2254): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 4407)
05-22 20:39:57.481+0900 I/AUL_AMD ( 2161): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4407
05-22 20:39:57.481+0900 D/AUL_AMD ( 2161): amd_key.c: _unregister_key_event(161) > ===key stack===
05-22 20:39:57.481+0900 D/AUL     ( 2161): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-22 20:39:57.481+0900 E/AUL     ( 2161): simple_util.c: __trm_app_info_send_socket(264) > access
05-22 20:39:57.601+0900 D/W_HOME  ( 2260): key.c: _key_press_cb(162) > Key pressed 1
05-22 20:39:57.601+0900 E/W_HOME  ( 2260): key.c: _key_press_cb(164) > (APP_STATE_PAUSE == main_get_info()->state) -> _key_press_cb() return
05-22 20:39:57.721+0900 D/W_HOME  ( 2260): key.c: _key_release_cb(135) > Key(XF86Stop) released 1
05-22 20:39:57.721+0900 D/APPS    ( 2260): layout.c: _back_key_cb(68) >  Back key cb
05-22 20:39:57.721+0900 D/APPS    ( 2260): layout.c: _back_key_cb(78) >  apps status:[1]
05-22 20:39:57.721+0900 D/APPS    ( 2260): layout.c: apps_layout_show(476) >  (0xb8773cc0) Hide the tray
05-22 20:39:57.721+0900 W/W_HOME  ( 2260): key.c: _execute_cbs(119) > back key execution has been stopped
05-22 20:39:57.781+0900 D/APP_CORE( 2260): appcore-efl.c: __hide_cb(848) > [EVENT_TEST][EVENT] GET HIDE EVENT!!!. WIN:1800007
05-22 20:39:57.781+0900 D/APP_CORE( 2260): appcore-efl.c: __hide_cb(855) >  Go to Pasue state 
05-22 20:39:57.781+0900 D/APP_CORE( 2260): appcore-efl.c: __do_app(470) > [APP 2260] Event: PAUSE State: RUNNING
05-22 20:39:57.781+0900 D/APP_CORE( 2260): appcore-efl.c: __do_app(538) > [APP 2260] PAUSE
05-22 20:39:57.781+0900 I/CAPI_APPFW_APPLICATION( 2260): app_main.c: _ui_app_appcore_pause(607) > app_appcore_pause
05-22 20:39:57.781+0900 D/W_HOME  ( 2260): main.c: _pause_cb(600) > Paused
05-22 20:39:57.781+0900 E/W_HOME  ( 2260): main.c: _pause_cb(603) > paused already
05-22 20:39:57.781+0900 D/APP_CORE( 2260): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
05-22 20:39:57.781+0900 E/APP_CORE( 2260): appcore-efl.c: __trm_app_info_send_socket(233) > access
05-22 20:39:57.781+0900 E/W_HOME  ( 2260): main.c: _window_focus_out_cb(885) > win[25165827], ev->win[25165831]
05-22 20:39:57.781+0900 D/APPS    ( 2260): apps_main.c: _window_focus_out_cb(308) >  focus out
05-22 20:39:57.781+0900 E/W_HOME  ( 2260): noti_broker.c: noti_broker_event_fire_to_plugin(657) > (s_info.is_loaded == 0) -> noti_broker_event_fire_to_plugin() return
05-22 20:39:57.781+0900 D/APPS    ( 2260): apps_main.c: apps_main_pause(656) >  Pause starts
05-22 20:39:57.781+0900 D/APPS    ( 2260): apps_main.c: apps_main_pause(676) >  Pause done
05-22 20:39:57.781+0900 E/EFL     ( 2260): edje<2260> edje_util.c:3592 edje_object_size_min_restricted_calc() group page_inner has a non-fixed part 'line,widget'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-22 20:39:57.781+0900 D/WIDGET_VIEWER( 2260): widget.c: widget_viewer_set_visibility(3860) > [SECURE_LOG] org.example.stemwatch has no changes
05-22 20:39:57.781+0900 E/EFL     ( 2260): edje<2260> edje_util.c:3592 edje_object_size_min_restricted_calc() group page_inner has a non-fixed part 'line,widget'. Adding 'fixed: 1 1;' to source EDC may help. Continuing discarding faulty part.
05-22 20:39:57.781+0900 D/WIDGET_VIEWER( 2260): widget.c: widget_viewer_set_visibility(3860) > [SECURE_LOG] org.example.stemwatch has no changes
05-22 20:39:57.781+0900 D/WIDGET_VIEWER( 2260): widget.c: widget_viewer_set_visibility(3860) > [SECURE_LOG] org.example.stemwatch has no changes
05-22 20:39:57.781+0900 D/WIDGET_VIEWER( 2260): widget.c: widget_viewer_set_visibility(3860) > [SECURE_LOG] org.example.stemwatch has no changes
05-22 20:39:57.901+0900 D/W_HOME  ( 2260): main.c: _window_focus_in_cb(848) > focus in
05-22 20:39:57.901+0900 D/W_HOME  ( 2260): main.c: _resume_cb(564) > Resumed
05-22 20:39:57.901+0900 D/APPS    ( 2260): apps_main.c: apps_main_is_visible(757) >  bShow:[0]
05-22 20:39:57.911+0900 D/W_HOME  ( 2260): scroller.c: _resume_result_cb(623) > Activate the rotary events for Home
05-22 20:39:57.911+0900 E/efl-extension( 2260): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb86f7b30, elm_scroller, _activated_obj : 0xb8772000, activated : 1
05-22 20:39:57.911+0900 E/efl-extension( 2260): efl_extension_rotary.c: eext_rotary_object_event_activated_set(309) > Activation delete!!!!
05-22 20:39:57.911+0900 D/W_HOME  ( 2260): clock_inf_widget.c: home_resumed_cb(277) > Thaw all freezed objects
05-22 20:39:57.911+0900 W/W_HOME  ( 2260): main.c: _resume_cb(589) > clock/widget resumed
05-22 20:39:57.911+0900 D/W_HOME  ( 2260): clock_view.c: clock_view_event_handler(843) > event:10004 received
05-22 20:39:57.911+0900 D/W_HOME  ( 2260): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
05-22 20:39:57.911+0900 E/APPS    ( 2260): apps_main.c: _window_focus_in_cb(293) >  win[25165831], ev->win[25165827]
05-22 20:39:57.911+0900 W/W_HOME  ( 2260): main.c: _window_visibility_cb(796) > Window [0x1800003] is now visible(0)
05-22 20:39:57.911+0900 D/APP_CORE( 2260): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1800003 fully_obscured 0
05-22 20:39:57.911+0900 D/APP_CORE( 2260): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 0
05-22 20:39:57.911+0900 D/APP_CORE( 2260): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
05-22 20:39:57.911+0900 D/APP_CORE( 2260): appcore-efl.c: __do_app(470) > [APP 2260] Event: RESUME State: PAUSED
05-22 20:39:57.911+0900 D/LAUNCH  ( 2260): appcore-efl.c: __do_app(557) > [w-home:Application:resume:start]
05-22 20:39:57.911+0900 D/APP_CORE( 2260): appcore-efl.c: __do_app(559) > [APP 2260] RESUME
05-22 20:39:57.911+0900 I/CAPI_APPFW_APPLICATION( 2260): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
05-22 20:39:57.911+0900 D/W_HOME  ( 2260): main.c: _resume_cb(564) > Resumed
05-22 20:39:57.911+0900 E/W_HOME  ( 2260): main.c: _resume_cb(567) > resumed already
05-22 20:39:57.911+0900 D/LAUNCH  ( 2260): appcore-efl.c: __do_app(567) > [w-home:Application:resume:done]
05-22 20:39:57.911+0900 D/LAUNCH  ( 2260): appcore-efl.c: __do_app(569) > [w-home:Application:Launching:done]
05-22 20:39:57.911+0900 D/APP_CORE( 2260): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
05-22 20:39:57.911+0900 E/APP_CORE( 2260): appcore-efl.c: __trm_app_info_send_socket(233) > access
05-22 20:39:57.921+0900 D/DATA_PROVIDER_MASTER( 2289): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2260 is resumed
05-22 20:39:57.921+0900 D/DATA_PROVIDER_MASTER( 2289): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
05-22 20:39:57.921+0900 D/WATCH_CORE( 4469): appcore-watch.c: __widget_resume(922) > widget_resume
05-22 20:39:57.921+0900 D/WATCH_CORE( 4469): appcore-watch.c: __do_app(332) > WE_RESUME
05-22 20:39:57.921+0900 W/CAPI_WATCH_APPLICATION( 4469): watch_app_main.c: _watch_core_resume(262) > _watch_core_resume
05-22 20:39:57.921+0900 D/WATCH_CORE( 4469): appcore-watch.c: __watch_core_time_tick(834) > state: 2
05-22 20:39:57.921+0900 D/WATCH_CORE( 4469): appcore-watch.c: __watch_core_time_tick(845) > next time tick: 0.063000
05-22 20:39:57.921+0900 I/CAPI_WATCH_APPLICATION( 4469): watch_app_main.c: _watch_core_time_tick(301) > _watch_core_time_tick
05-22 20:39:57.991+0900 D/WATCH_CORE( 4469): appcore-watch.c: __watch_core_time_tick(834) > state: 2
05-22 20:39:57.991+0900 D/WATCH_CORE( 4469): appcore-watch.c: __watch_core_time_tick(845) > next time tick: 0.999000
05-22 20:39:57.991+0900 I/CAPI_WATCH_APPLICATION( 4469): watch_app_main.c: _watch_core_time_tick(301) > _watch_core_time_tick
05-22 20:39:58.831+0900 I/GESTURE ( 2030): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
05-22 20:39:58.871+0900 D/EFL     ( 2260): ecore_x<2260> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=5211834 button=1
05-22 20:39:58.871+0900 D/W_HOME  ( 2260): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
05-22 20:39:58.871+0900 D/W_HOME  ( 2260): dbus_util.c: home_dbus_scroll_booster_signal_send(296) > Sending scroll booster for 200 sec result:0
05-22 20:39:58.871+0900 D/W_HOME  ( 2260): layout.c: _gesture_down_cb(611) > Mouse is down on the gesture layer:266
05-22 20:39:58.871+0900 D/W_HOME  ( 2260): layout.c: _down_cb(250) > Mouse is down on the layout
05-22 20:39:58.871+0900 W/W_HOME  ( 2260): layout.c: _down_cb(280) > we don't add a longpress timer, it's too close to home key
05-22 20:39:58.871+0900 D/W_HOME  ( 2260): page.c: _down_cb(84) > Down (0xb88d7248)(182, 266)
05-22 20:39:58.871+0900 D/WIDGET_EVAS( 2260): widget_viewer_evas.c: __widget_down_cb(1500) > [SECURE_LOG] Change to direct render
05-22 20:39:58.871+0900 D/WIDGET_EVAS( 2260): widget_viewer_evas.c: __widget_down_cb(1540) > [SECURE_LOG] 182.000000x266.000000 (1.000000x1.000000)
05-22 20:39:58.911+0900 D/WIDGET_PROVIDER( 4469): widget_provider_buffer.c: provider_buffer_widget_mouse_down(603) > [SECURE_LOG] Down: file:///opt/usr/share/live_magazine/org.example.stemwatch_2260_5207.816895.png
05-22 20:39:58.911+0900 E/WIDGET  ( 4469): virtual_window.c: processing_events(212) > [SECURE_LOG] DOWN[/opt/usr/share/live_magazine/org.example.stemwatch_2260_5207.816895.png] 182x266 - 5211887.695312 (0)
05-22 20:39:58.941+0900 D/EFL     ( 2260): ecore_x<2260> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=5211952 button=1
05-22 20:39:58.941+0900 D/W_HOME  ( 2260): layout.c: _up_cb(324) > Mouse is up on the layout
05-22 20:39:58.941+0900 D/W_HOME  ( 2260): page.c: _up_cb(115) > Up (0xb88d7248)(183, 266)
05-22 20:39:58.941+0900 D/WIDGET_EVAS( 2260): widget_viewer_evas.c: __widget_up_cb(3047) > [SECURE_LOG] Change to render animator
05-22 20:39:58.941+0900 D/WIDGET_EVAS( 2260): widget_viewer_evas.c: __widget_up_cb(3177) > [SECURE_LOG] 183.000000x266.000000 (1.000000x1.000000)
05-22 20:39:58.941+0900 D/WIDGET_VIEWER( 2260): widget.c: widget_viewer_send_click_event(1876) > [SECURE_LOG] CLICKED: 5211.960449
05-22 20:39:58.951+0900 D/WIDGET_EVAS( 2260): widget_viewer_evas.c: __widget_up_cb(3199) > [SECURE_LOG] Up: 183.000000x266.000000 [x:0/1/0] [y:0/0/0], ret: 0x0, cancel: 0x0
05-22 20:39:58.971+0900 D/WIDGET_PROVIDER( 4469): widget_provider_buffer.c: provider_buffer_widget_mouse_up(639) > [SECURE_LOG] Up: file:///opt/usr/share/live_magazine/org.example.stemwatch_2260_5207.816895.png
05-22 20:39:58.971+0900 E/WIDGET  ( 4469): virtual_window.c: processing_events(248) > [SECURE_LOG] UP[/opt/usr/share/live_magazine/org.example.stemwatch_2260_5207.816895.png] 183x266 - 5211958.496094 (0)
05-22 20:39:58.991+0900 W/CRASH_MANAGER( 4327): worker.c: worker_job(1189) > 1104469737465146391719
