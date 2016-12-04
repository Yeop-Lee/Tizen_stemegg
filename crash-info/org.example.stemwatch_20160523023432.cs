S/W Version Information
Model: SM-R735S
Tizen-Version: 2.3.1.4
Build-Number: R735SKSU1BPD1
Build-Date: 2016.04.06 15:13:39

Crash Information
Process Name: stemwatch
PID: 4295
Date: 2016-05-23 02:34:32+0900
Executable File Path: /opt/usr/apps/org.example.stemwatch/bin/stemwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x10d

Register Information
r0   = 0x00000101, r1   = 0x0000000d
r2   = 0x00000011, r3   = 0xb580a194
r4   = 0x00000101, r5   = 0x00000000
r6   = 0xb7a8f3ec, r7   = 0xb7a6de08
r8   = 0x00000076, r9   = 0x00000000
r10  = 0xe202db23, fp   = 0xb6f6cdc0
ip   = 0xbeaeccc4, sp   = 0xbeaecc78
lr   = 0xb6f520d0, pc   = 0xb6f519dc
cpsr = 0x20000010

Memory Information
MemTotal:   407572 KB
MemFree:     18800 KB
Buffers:      8128 KB
Cached:      80952 KB
VmPeak:      93804 KB
VmSize:      93260 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15852 KB
VmRSS:       15852 KB
VmData:      38556 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       22304 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 4295 TID = 4295
4295 4380 4388 

Maps Information
b1775000 b1f74000 rwxp [stack:4388]
b2963000 b2964000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b317b000 b3192000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b319f000 b3226000 rw-s anon_inode:dmabuf
b3226000 b3231000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b323a000 b323c000 r-xp /usr/lib/libgenlock.so
b3245000 b3247000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b324f000 b3252000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnueabi-armv7l-1.7.99/module.so
b325b000 b3a5a000 rwxp [stack:4380]
b3d8b000 b3e55000 r-xp /usr/lib/libCOREGL.so.4.0
b3e66000 b3e6d000 r-xp /usr/lib/libtbm.so.1.0.0
b3e75000 b3e77000 r-xp /usr/lib/libdri2.so.0.0.0
b3e7f000 b3e84000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3e8c000 b3e94000 r-xp /usr/lib/libdrm.so.2.4.0
b3e9c000 b3ea2000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3eaa000 b3eab000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b3eb4000 b3eb7000 r-xp /usr/lib/libEGL.so.1.4
b3ebf000 b3ecd000 r-xp /usr/lib/libGLESv2.so.2.0
b3ed6000 b3edf000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b3ee8000 b3ef4000 r-xp /usr/lib/libwidget_service.so.1.0.0
b3efc000 b3f05000 r-xp /usr/lib/libcom-core.so.0.0.1
b5495000 b554d000 r-xp /usr/lib/libcairo.so.2.11200.14
b5558000 b555e000 r-xp /usr/lib/libwidget.so.1.0.0
b5567000 b556d000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b5575000 b5659000 r-xp /usr/lib/libicuuc.so.51.1
b566e000 b57ab000 r-xp /usr/lib/libicui18n.so.51.1
b57bb000 b57c8000 r-xp /usr/lib/libalarm.so.0.0.0
b57d1000 b57f2000 r-xp /usr/lib/libefl-extension.so.0.1.0
b57fa000 b5801000 r-xp /usr/lib/libappcore-watch.so.1.1
b580a000 b580d000 r-xp /opt/usr/apps/org.example.stemwatch/bin/stemwatch
b59b4000 b59be000 r-xp /lib/libnss_files-2.13.so
b59c7000 b5a96000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b5aac000 b5ad0000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b5ad9000 b5adf000 r-xp /usr/lib/libappsvc.so.0.1.0
b5ae7000 b5ae9000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.2.5
b5af2000 b5af6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.2.5
b5b08000 b5b0d000 r-xp /usr/lib/bufmgr/libtbm_msm.so.0.0.0
b5b15000 b5b17000 r-xp /usr/lib/libiniparser.so.0
b5b20000 b5b25000 r-xp /usr/lib/libappcore-common.so.1.1
b5b2d000 b5b2f000 r-xp /usr/lib/libcapi-appfw-alarm.so.0.3.2.5
b5b37000 b5b3b000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.2.5
b5b48000 b5b4a000 r-xp /usr/lib/libXau.so.6.0.0
b5b53000 b5b5a000 r-xp /lib/libcrypt-2.13.so
b5b8a000 b5b8c000 r-xp /usr/lib/libiri.so
b5b94000 b5d3c000 r-xp /usr/lib/libcrypto.so.1.0.0
b5d55000 b5da2000 r-xp /usr/lib/libssl.so.1.0.0
b5daf000 b5ddd000 r-xp /usr/lib/libidn.so.11.5.44
b5de5000 b5dee000 r-xp /usr/lib/libcares.so.2.1.0
b5df7000 b5e0a000 r-xp /usr/lib/libxcb.so.1.1.0
b5e13000 b5e15000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b5e1e000 b5e20000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5e29000 b5ef5000 r-xp /usr/lib/libxml2.so.2.7.8
b5f02000 b5f04000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b5f0c000 b5f11000 r-xp /usr/lib/libffi.so.5.0.10
b5f19000 b5f1a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b5f23000 b5f2e000 r-xp /usr/lib/libgpg-error.so.0.15.0
b5f36000 b5f39000 r-xp /lib/libattr.so.1.1.0
b5f41000 b5fd5000 r-xp /usr/lib/libstdc++.so.6.0.16
b5fe8000 b6005000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b600d000 b6025000 r-xp /usr/lib/libpng12.so.0.50.0
b602e000 b6044000 r-xp /lib/libexpat.so.1.5.2
b604e000 b6092000 r-xp /usr/lib/libcurl.so.4.3.0
b609b000 b60a5000 r-xp /usr/lib/libXext.so.6.4.0
b60ae000 b60b2000 r-xp /usr/lib/libXtst.so.6.1.0
b60ba000 b60c0000 r-xp /usr/lib/libXrender.so.1.3.0
b60c9000 b60cf000 r-xp /usr/lib/libXrandr.so.2.2.0
b60d7000 b60d8000 r-xp /usr/lib/libXinerama.so.1.0.0
b60e1000 b60ea000 r-xp /usr/lib/libXi.so.6.1.0
b60f2000 b60f5000 r-xp /usr/lib/libXfixes.so.3.1.0
b60fd000 b60ff000 r-xp /usr/lib/libXgesture.so.7.0.0
b6107000 b6109000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6112000 b6114000 r-xp /usr/lib/libXdamage.so.1.1.0
b611c000 b6123000 r-xp /usr/lib/libXcursor.so.1.0.2
b612b000 b612e000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6136000 b613a000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6143000 b6148000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6152000 b6233000 r-xp /usr/lib/libX11.so.6.3.0
b623e000 b6261000 r-xp /usr/lib/libjpeg.so.8.0.2
b6279000 b628f000 r-xp /lib/libz.so.1.2.5
b6297000 b630c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6316000 b632c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6335000 b6369000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6372000 b6445000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6450000 b6460000 r-xp /lib/libresolv-2.13.so
b6464000 b64e0000 r-xp /usr/lib/libgcrypt.so.20.0.3
b64ec000 b6504000 r-xp /usr/lib/liblzma.so.5.0.3
b650d000 b6510000 r-xp /lib/libcap.so.2.21
b6518000 b6543000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b654b000 b654c000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b6554000 b655a000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6562000 b6579000 r-xp /usr/lib/liblua-5.1.so
b6583000 b658a000 r-xp /usr/lib/libembryo.so.1.7.99
b6592000 b6598000 r-xp /lib/librt-2.13.so
b65a1000 b65f7000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6604000 b665a000 r-xp /usr/lib/libfreetype.so.6.11.3
b6666000 b668e000 r-xp /usr/lib/libfontconfig.so.1.8.0
b6690000 b66cd000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b66d6000 b66e9000 r-xp /usr/lib/libfribidi.so.0.3.1
b66f1000 b670b000 r-xp /usr/lib/libecore_con.so.1.7.99
b6714000 b671d000 r-xp /usr/lib/libedbus.so.1.7.99
b6725000 b6775000 r-xp /usr/lib/libecore_x.so.1.7.99
b6778000 b677c000 r-xp /usr/lib/libvconf.so.0.2.45
b6784000 b6795000 r-xp /usr/lib/libecore_input.so.1.7.99
b679d000 b67a2000 r-xp /usr/lib/libecore_file.so.1.7.99
b67aa000 b67cc000 r-xp /usr/lib/libecore_evas.so.1.7.99
b67d5000 b6816000 r-xp /usr/lib/libeina.so.1.7.99
b681f000 b6838000 r-xp /usr/lib/libeet.so.1.7.99
b6849000 b68b2000 r-xp /lib/libm-2.13.so
b68bb000 b68c1000 r-xp /usr/lib/libcapi-base-common.so.0.1.8
b68ca000 b68cd000 r-xp /usr/lib/libproc-stat.so.0.2.86
b68d5000 b68f7000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b68ff000 b6904000 r-xp /usr/lib/libxdgmime.so.1.1.0
b690c000 b6936000 r-xp /usr/lib/libdbus-1.so.3.8.12
b693f000 b6956000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b695e000 b6969000 r-xp /lib/libunwind.so.8.0.1
b6996000 b69d2000 r-xp /usr/lib/libsystemd.so.0.4.0
b69db000 b6af6000 r-xp /lib/libc-2.13.so
b6b04000 b6b0c000 r-xp /lib/libgcc_s-4.6.so.1
b6b0d000 b6b10000 r-xp /usr/lib/libsmack.so.1.0.0
b6b18000 b6b1e000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6b26000 b6bf6000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6bf7000 b6c54000 r-xp /usr/lib/libedje.so.1.7.99
b6c5e000 b6c75000 r-xp /usr/lib/libecore.so.1.7.99
b6c8c000 b6d5a000 r-xp /usr/lib/libevas.so.1.7.99
b6d7f000 b6eba000 r-xp /usr/lib/libelementary.so.1.7.99
b6ed0000 b6ee4000 r-xp /lib/libpthread-2.13.so
b6eef000 b6ef1000 r-xp /usr/lib/libdlog.so.0.0.0
b6ef9000 b6efc000 r-xp /usr/lib/libbundle.so.0.1.22
b6f04000 b6f06000 r-xp /lib/libdl-2.13.so
b6f0f000 b6f1b000 r-xp /usr/lib/libaul.so.0.1.0
b6f2d000 b6f32000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f3b000 b6f3f000 r-xp /usr/lib/libsys-assert.so
b6f48000 b6f65000 r-xp /lib/ld-2.13.so
b6f6e000 b6f73000 r-xp /usr/bin/launchpad-loader
b797c000 b7b6f000 rw-p [heap]
beacd000 beaee000 rwxp [stack]
End of Maps Information

Callstack Information (PID:4295)
Call Stack Count: 6
 0: (0xb6f519dc) [/lib/ld-linux.so.3] + 0x99dc
 1: (0xb6f520d0) [/lib/ld-linux.so.3] + 0xa0d0
 2: (0xb6f52360) [/lib/ld-linux.so.3] + 0xa360
 3: (0xb6f565e4) [/lib/ld-linux.so.3] + 0xe5e4
 4: (0xb6f5ca60) [/lib/ld-linux.so.3] + 0x14a60
 5: (0xb6a4870c) [/lib/libc.so.6] + 0x6d70c
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
request_handler(646) > __request_handler: 22
05-23 02:34:05.952+0900 W/AUL_AMD (  929): amd_request.c: __request_handler(890) > app status : 4
05-23 02:34:05.952+0900 W/AUL_AMD (  929): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(3826), cmd(4)
05-23 02:34:05.952+0900 W/AUL_AMD (  929): amd_request.c: __request_handler(646) > __request_handler: 4
05-23 02:34:05.952+0900 W/AUL_AMD (  929): amd_request.c: __request_handler(646) > __request_handler: 14
05-23 02:34:05.962+0900 W/AUL_AMD (  929): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 3826
05-23 02:34:05.962+0900 I/efl-extension( 3826): efl_extension.c: eext_mod_shutdown(46) > Shutdown
05-23 02:34:06.062+0900 W/AUL_AMD (  929): amd_request.c: __request_handler(646) > __request_handler: 14
05-23 02:34:06.072+0900 W/AUL_AMD (  929): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: -1
05-23 02:34:06.082+0900 E/PKGMGR_SERVER( 4377): pkgmgr-server.c: queue_job(1971) > KILL/CHECK_APP end.
05-23 02:34:06.092+0900 E/PKGMGR  ( 4370): pkgmgr.c: __check_sync_process(843) > file is can not remove[/tmp/org.example.stemwatch, -1]
05-23 02:34:06.102+0900 E/AUL_AMD (  929): amd_launch.c: __reply_handler(892) > recv error : Connection reset by peer
05-23 02:34:06.102+0900 W/AUL_AMD (  929): amd_launch.c: __reply_handler(916) > listen fd(21) , send fd(20), pid(3826), cmd(4)
05-23 02:34:06.102+0900 W/AUL_AMD (  929): amd_request.c: __request_handler(646) > __request_handler: 0
05-23 02:34:06.132+0900 I/AUL_AMD (  929): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-23 02:34:06.152+0900 I/AUL_AMD (  929): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-23 02:34:06.152+0900 E/AUL_AMD (  929): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-23 02:34:06.152+0900 W/AUL_AMD (  929): amd_launch.c: _start_app(1702) > caller pid : 1206
05-23 02:34:06.172+0900 W/AUL_AMD (  929): amd_launch.c: _start_app(2080) > pad pid(-5)
05-23 02:34:06.172+0900 W/AUL_PAD ( 1647): launchpad.c: __launchpad_main_loop(587) > Launch on type-based process-pool
05-23 02:34:06.172+0900 W/AUL_PAD ( 1647): launchpad.c: __send_result_to_caller(272) > Check app launching
05-23 02:34:06.182+0900 E/PKGMGR_SERVER( 4372): pkgmgr-server.c: sighandler(409) > child NORMAL exit [4377]
05-23 02:34:06.212+0900 E/RESOURCED(  931): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.stemwatch, table num : 6
05-23 02:34:06.212+0900 E/RESOURCED(  931): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-23 02:34:06.232+0900 I/efl-extension( 4295): efl_extension.c: eext_mod_init(40) > Init
05-23 02:34:06.232+0900 I/CAPI_WATCH_APPLICATION( 4295): watch_app_main.c: watch_app_main(392) > watch_app_main
05-23 02:34:06.272+0900 I/AUL_AMD (  929): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3826
05-23 02:34:06.272+0900 E/AUL     (  929): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-23 02:34:06.312+0900 W/WATCH_CORE( 4295): appcore-watch.c: __widget_create(959) > widget_create
05-23 02:34:06.412+0900 W/WATCH_CORE( 4295): appcore-watch.c: __widget_create(977) > widget_create done
05-23 02:34:06.472+0900 I/WATCH_CORE( 4295): appcore-watch.c: __watch_core_set_metadata(808) > No metadata info for the tick per second
05-23 02:34:06.472+0900 I/WATCH_CORE( 4295): appcore-watch.c: __watch_core_set_metadata(828) > No metadata info for the background tick update
05-23 02:34:06.472+0900 I/WATCH_CORE( 4295): appcore-watch.c: __watch_core_set_metadata(840) > No metadata info for the watchface
05-23 02:34:07.282+0900 W/AUL_AMD (  929): amd_key.c: _key_ungrab(254) > fail(-1) to ungrab key(XF86Stop)
05-23 02:34:07.282+0900 W/AUL_AMD (  929): amd_launch.c: __grab_timeout_handler(1369) > back key ungrab error
05-23 02:34:07.292+0900 W/AUL_AMD (  929): amd_request.c: __request_handler(646) > __request_handler: 14
05-23 02:34:07.302+0900 W/AUL_AMD (  929): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 4295
05-23 02:34:07.302+0900 W/AUL_AMD (  929): amd_request.c: __request_handler(646) > __request_handler: 12
05-23 02:34:07.412+0900 E/EFL     ( 4389): elementary<4389> elm_main.c:558 elm_quicklaunch_init() eet_init done.
05-23 02:34:07.422+0900 E/EFL     ( 4389): elementary<4389> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
05-23 02:34:07.442+0900 E/EFL     ( 4389): elementary<4389> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
05-23 02:34:07.442+0900 E/EFL     ( 4389): elementary<4389> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
05-23 02:34:07.462+0900 E/EFL     ( 4389): elementary<4389> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
05-23 02:34:07.472+0900 E/EFL     ( 4389): elementary<4389> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
05-23 02:34:07.472+0900 E/EFL     ( 4389): elementary<4389> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
05-23 02:34:07.472+0900 E/EFL     ( 4389): elementary<4389> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
05-23 02:34:07.472+0900 E/EFL     ( 4389): elementary<4389> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
05-23 02:34:07.482+0900 E/EFL     ( 4389): elementary<4389> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
05-23 02:34:07.492+0900 E/EFL     ( 4389): elementary<4389> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
05-23 02:34:07.492+0900 E/EFL     ( 4389): elementary<4389> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
05-23 02:34:07.522+0900 E/EFL     ( 4389): elementary<4389> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
05-23 02:34:07.532+0900 E/EFL     ( 4389): elementary<4389> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
05-23 02:34:07.532+0900 E/EFL     ( 4389): elementary<4389> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
05-23 02:34:07.532+0900 E/EFL     ( 4389): elementary<4389> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
05-23 02:34:07.532+0900 E/EFL     ( 4389): elementary<4389> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
05-23 02:34:07.532+0900 E/EFL     ( 4389): elementary<4389> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
05-23 02:34:07.532+0900 E/EFL     ( 4389): elementary<4389> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
05-23 02:34:07.532+0900 I/AUL_PAD ( 4389): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-23 02:34:07.952+0900 W/AUL_AMD (  929): amd_status.c: __app_terminate_timer_cb(166) > send SIGKILL: No such process
05-23 02:34:07.992+0900 E/PKGMGR_SERVER( 4372): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
05-23 02:34:07.992+0900 E/PKGMGR_SERVER( 4372): pkgmgr-server.c: main(2185) > package manager server terminated.
05-23 02:34:09.672+0900 E/SHealth_Common( 1542): SHealthMessagePortConnection.cpp: Send(360) > [0;40;31mexception [[Send]Send appIdList is empty][0;m
05-23 02:34:20.392+0900 I/RESOURCED(  931): logging.c: logging_send_signal_to_data(1097) > [logging_send_signal_to_data,1097] send signal to logging data thread
05-23 02:34:20.392+0900 I/RESOURCED(  931): logging.c: logging_send_signal_to_update(1177) > [logging_send_signal_to_update,1177] send signal to logging update thread
05-23 02:34:26.112+0900 W/WATCH_CORE( 4295): appcore-watch.c: __signal_context_handler(1193) > _signal_context_handler: type: 0, state: 1
05-23 02:34:26.112+0900 I/WATCH_CORE( 4295): appcore-watch.c: __signal_context_handler(1197) > Skip the background tick update
05-23 02:34:26.112+0900 W/W_HOME  ( 1252): dbus.c: _dbus_message_recv_cb(169) > gesture:wristup
05-23 02:34:26.112+0900 W/W_HOME  ( 1252): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-23 02:34:26.112+0900 W/WAKEUP-SERVICE( 1445): WakeupService.cpp: OnReceiveGestureChanged(993) > [0;32mINFO: wakeup receive data : -1195647416[0;m
05-23 02:34:26.112+0900 W/WAKEUP-SERVICE( 1445): WakeupService.cpp: OnReceiveGestureChanged(994) > [0;32mINFO: WakeupServiceStart[0;m
05-23 02:34:26.112+0900 W/WAKEUP-SERVICE( 1445): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-23 02:34:26.122+0900 W/WATCH_CORE( 4295): appcore-watch.c: __signal_lcd_status_handler(1131) > signal_lcd_status_signal: LCDOn
05-23 02:34:26.122+0900 I/WATCH_CORE( 4295): appcore-watch.c: __signal_lcd_status_handler(1135) > Skip the background tick update
05-23 02:34:26.132+0900 W/WAKEUP-SERVICE( 1445): WakeupService.cpp: OnReceiveDisplayChanged(968) > [0;32mINFO: LCDOn receive data : -1226691828[0;m
05-23 02:34:26.132+0900 W/WAKEUP-SERVICE( 1445): WakeupService.cpp: OnReceiveDisplayChanged(969) > [0;32mINFO: WakeupServiceStart[0;m
05-23 02:34:26.132+0900 W/WAKEUP-SERVICE( 1445): WakeupService.cpp: WakeupServiceStart(376) > [0;32mINFO: SEAMLESS WAKEUP START REQUEST[0;m
05-23 02:34:26.132+0900 W/W_HOME  ( 1252): dbus.c: _dbus_message_recv_cb(186) > LCD on
05-23 02:34:26.132+0900 W/W_HOME  ( 1252): gesture.c: _manual_render_disable_timer_set(161) > timer set
05-23 02:34:26.132+0900 W/W_HOME  ( 1252): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-23 02:34:26.132+0900 W/W_HOME  ( 1252): gesture.c: _apps_status_get(123) > apps status:0
05-23 02:34:26.132+0900 W/W_HOME  ( 1252): gesture.c: _lcd_on_cb(295) > move_to_clock:1 clock_visible:1 info->offtime:120423
05-23 02:34:26.132+0900 W/W_HOME  ( 1252): gesture.c: _manual_render_schedule(211) > schedule, manual render
05-23 02:34:26.132+0900 W/W_HOME  ( 1252): event_manager.c: _lcd_on_cb(691) > lcd state: 1
05-23 02:34:26.132+0900 W/W_HOME  ( 1252): event_manager.c: _state_control(194) > control:4, app_state:2 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-23 02:34:26.132+0900 W/STARTER ( 1145): clock-mgr.c: _on_lcd_signal_receive_cb(1520) > [_on_lcd_signal_receive_cb:1520] _on_lcd_signal_receive_cb, 1520, Pre LCD on by [gesture] after screen off time [120423]ms
05-23 02:34:26.132+0900 W/STARTER ( 1145): clock-mgr.c: _pre_lcd_on(1246) > [_pre_lcd_on:1246] Will LCD ON as reserved app[(null)] alpm mode[0]
05-23 02:34:26.142+0900 I/APP_CORE( 1252): appcore-efl.c: __do_app(429) > [APP 1252] Event: RESUME State: PAUSED
05-23 02:34:26.142+0900 I/CAPI_APPFW_APPLICATION( 1252): app_main.c: app_appcore_resume(223) > app_appcore_resume
05-23 02:34:26.142+0900 W/W_HOME  ( 1252): main.c: _appcore_resume_cb(683) > appcore resume
05-23 02:34:26.142+0900 W/W_HOME  ( 1252): event_manager.c: _app_resume_cb(355) > state: 2 -> 1
05-23 02:34:26.142+0900 W/W_HOME  ( 1252): event_manager.c: _state_control(194) > control:2, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-23 02:34:26.142+0900 W/W_HOME  ( 1252): event_manager.c: _state_control(194) > control:0, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-23 02:34:26.142+0900 W/W_HOME  ( 1252): main.c: home_resume(731) > journal_appcore_app_fully_loaded called
05-23 02:34:26.142+0900 W/W_HOME  ( 1252): main.c: home_resume(735) > clock/widget resumed
05-23 02:34:26.142+0900 W/W_HOME  ( 1252): event_manager.c: _state_control(194) > control:1, app_state:1 win_state:0(1) pm_state:1 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-23 02:34:26.142+0900 I/GESTURE (  260): gesture.c: BackGestureSetProperty(4473) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=1, Clock display 
05-23 02:34:26.222+0900 W/MUSIC_CONTROL_SERVICE( 1490): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(478) > [36m[TID:1490]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_NORMAL[0m
05-23 02:34:26.242+0900 W/STARTER ( 1145): clock-mgr.c: _on_lcd_signal_receive_cb(1531) > [_on_lcd_signal_receive_cb:1531] _on_lcd_signal_receive_cb, 1531, Post LCD on by [gesture]
05-23 02:34:26.242+0900 W/STARTER ( 1145): clock-mgr.c: _post_lcd_on(1292) > [_post_lcd_on:1292] LCD ON as reserved app[(null)] alpm mode[0]
05-23 02:34:26.252+0900 I/SHealth_Common( 1542): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:1[0;m
05-23 02:34:26.252+0900 I/SHealth_Service( 1542): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-23 02:34:26.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1542): preference.c: _preference_check_retry_err(507) > key(pedometer_inactive_period), check retry err: -21/(2/No such file or directory).
05-23 02:34:26.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1542): preference.c: _preference_get_key(1101) > _preference_get_key(pedometer_inactive_period) step(-17825744) failed(2 / No such file or directory)
05-23 02:34:26.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1542): preference.c: preference_get_double(1214) > preference_get_double(1542) : pedometer_inactive_period error
05-23 02:34:26.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1542): preference.c: _preference_check_retry_err(507) > key(inactive_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-23 02:34:26.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1542): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-23 02:34:26.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1542): preference.c: preference_get_double(1214) > preference_get_double(1542) : inactive_10min_precaution_millisec error
05-23 02:34:26.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1542): preference.c: _preference_check_retry_err(507) > key(inactive_before_10min_precaution_millisec), check retry err: -21/(2/No such file or directory).
05-23 02:34:26.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1542): preference.c: _preference_get_key(1101) > _preference_get_key(inactive_before_10min_precaution_millisec) step(-17825744) failed(2 / No such file or directory)
05-23 02:34:26.252+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 1542): preference.c: preference_get_double(1214) > preference_get_double(1542) : inactive_before_10min_precaution_millisec error
05-23 02:34:26.262+0900 I/HealthDataService( 1544): RequestHandler.cpp: OnHealthIpcMessageSync2ndParty(147) > [1;35mServer Received: SHARE_ADD[0;m
05-23 02:34:26.272+0900 I/healthData( 1542): client_dbus_connection.c: client_dbus_sendto_server_sync_with_2nd_party(327) > [1;35mServer said: OK {}[0;m
05-23 02:34:26.332+0900 W/W_HOME  ( 1252): gesture.c: _manual_render_disable_timer_cb(140) > timeout callback expired
05-23 02:34:26.332+0900 W/W_HOME  ( 1252): gesture.c: _manual_render_enable(133) > 0
05-23 02:34:26.792+0900 E/PKGMGR  ( 4483): pkgmgr.c: pkgmgr_client_reinstall(1835) > reinstall pkg start.
05-23 02:34:26.952+0900 E/PKGMGR_SERVER( 4485): pkgmgr-server.c: main(2131) > package manager server start
05-23 02:34:27.012+0900 E/PKGMGR_SERVER( 4485): pkgmgr-server.c: req_cb(650) > req_id=[org.example.stemwatch_-1136033366], req_type=[1], pkg_type=[rpm], pkgid=[org.example.stemwatch], args=[/usr/etc/package-manager/backend/rpm '-k' 'org.example.stemwatch_-1136033366' '-r' 'org.example.stemwatch'], cookie=[P1nPVU8sh2uHRZJI0t/I8r5Kmu8=], backend_flag=[0]
05-23 02:34:27.022+0900 E/PKGMGR  ( 4485): pkgmgr-internal.c: _get_type_from_zip(733) > can not access to [org.example.stemwatch]
05-23 02:34:27.022+0900 E/PKGMGR_SERVER( 4485): pkgmgr-server.c: __get_type_from_msg(328) > pkgtype is null for org.example.stemwatch 
05-23 02:34:27.022+0900 E/PKGMGR_SERVER( 4486): pkgmgr-server.c: queue_job(1815) > INSTALL start, pkg path=[org.example.stemwatch]
05-23 02:34:27.022+0900 E/PKGMGR  ( 4483): pkgmgr.c: pkgmgr_client_reinstall(1947) > reinstall pkg finish, ret=[44830002]
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-23 02:34:27.142+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-23 02:34:27.162+0900 E/CAPI_APPFW_APP_CONTROL( 1490): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-23 02:34:27.162+0900 W/MUSIC_CONTROL_SERVICE( 1490): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1490]   [com.samsung.w-home]register msg port [true][0m
05-23 02:34:27.162+0900 W/W_HOME  ( 1252): clock_event.c: _pkgmgr_event_cb(209) > Pkg:org.example.stemwatch is being updateded:0
05-23 02:34:27.162+0900 E/WMS     (  924): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, STARTED]
05-23 02:34:27.172+0900 W/AUL_AMD (  929): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(783) > __amd_pkgmgrinfo_start_handler
05-23 02:34:27.182+0900 E/WMS     (  924): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
05-23 02:34:27.182+0900 W/AUL_AMD (  929): amd_request.c: __request_handler(646) > __request_handler: 14
05-23 02:34:27.192+0900 W/AUL_AMD (  929): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1459
05-23 02:34:27.192+0900 W/AUL_AMD (  929): amd_request.c: __request_handler(646) > __request_handler: 14
05-23 02:34:27.202+0900 W/AUL_AMD (  929): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1252
05-23 02:34:27.202+0900 W/MUSIC_CONTROL_SERVICE( 1490): music-control-message.c: music_control_message_send_media_changed_ind(229) > [36m[TID:1490]   [MUSIC_PLAYER_EVENT][0m
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-23 02:34:27.202+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-23 02:34:27.202+0900 W/W_HOME  ( 1252): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
05-23 02:34:27.202+0900 E/W_HOME  ( 1252): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-23 02:34:27.202+0900 W/MUSIC_CONTROL_SERVICE( 1490): music-control-message.c: music_control_message_send_player_state_changed_ind(254) > [36m[TID:1490]   [MUSIC_PLAYER_EVENT][0m
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-23 02:34:27.212+0900 W/W_HOME  ( 1252): clock_shortcut.c: _music_service_messageport_cb(361) > mode:local state:paused 
05-23 02:34:27.212+0900 E/W_HOME  ( 1252): clock_shortcut.c: _mp_state_get(104) > (s_info.music_service.state != 1) -> _mp_state_get() return
05-23 02:34:27.212+0900 I/TIZEN_N_SOUND_MANAGER( 1490): sound_manager.c: sound_manager_get_volume(84) > returns : type=4, volume=14, ret=0x0
05-23 02:34:27.212+0900 W/TIZEN_N_SOUND_MANAGER( 1490): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_get_volume] ERROR_NONE (0x00000000)
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-home:music-control-service-message-port]
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-home:music-control-service-message-port]
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-23 02:34:27.212+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-23 02:34:27.472+0900 W/CERT_SVC( 4486): DUID.cpp: CheckCertifiedDevice(675) > No device id on distributor certificate
05-23 02:34:27.672+0900 E/WMS     (  924): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
05-23 02:34:27.672+0900 E/PKGMGR_CERT( 4486): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(426) > Transaction Begin
05-23 02:34:27.682+0900 E/PKGMGR_CERT( 4486): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 1 107
05-23 02:34:27.682+0900 E/PKGMGR_CERT( 4486): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 2 107
05-23 02:34:27.682+0900 E/PKGMGR_CERT( 4486): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 31 11
05-23 02:34:27.682+0900 E/PKGMGR_CERT( 4486): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 32 11
05-23 02:34:27.682+0900 E/PKGMGR_CERT( 4486): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 33 11
05-23 02:34:27.682+0900 E/PKGMGR_CERT( 4486): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(495) > Id:Count = 34 11
05-23 02:34:27.692+0900 E/PKGMGR_CERT( 4486): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(570) > Transaction Commit and End
05-23 02:34:27.862+0900 I/AUL_AMD (  929): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 3827
05-23 02:34:27.952+0900 I/AUL_AMD (  929): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 4389
05-23 02:34:28.022+0900 E/EFL     ( 4488): elementary<4488> elm_main.c:558 elm_quicklaunch_init() eet_init done.
05-23 02:34:28.022+0900 E/EFL     ( 4488): elementary<4488> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
05-23 02:34:28.062+0900 E/EFL     ( 4488): elementary<4488> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
05-23 02:34:28.062+0900 E/EFL     ( 4488): elementary<4488> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
05-23 02:34:28.082+0900 E/EFL     ( 4488): elementary<4488> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
05-23 02:34:28.082+0900 E/EFL     ( 4488): elementary<4488> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
05-23 02:34:28.092+0900 E/EFL     ( 4488): elementary<4488> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
05-23 02:34:28.092+0900 E/EFL     ( 4488): elementary<4488> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
05-23 02:34:28.092+0900 E/EFL     ( 4488): elementary<4488> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
05-23 02:34:28.102+0900 E/EFL     ( 4488): elementary<4488> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
05-23 02:34:28.112+0900 E/EFL     ( 4488): elementary<4488> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
05-23 02:34:28.112+0900 E/EFL     ( 4488): elementary<4488> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
05-23 02:34:28.132+0900 E/EFL     ( 4488): elementary<4488> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
05-23 02:34:28.142+0900 E/EFL     ( 4488): elementary<4488> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
05-23 02:34:28.152+0900 E/EFL     ( 4488): elementary<4488> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
05-23 02:34:28.162+0900 E/EFL     ( 4488): elementary<4488> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
05-23 02:34:28.162+0900 E/EFL     ( 4488): elementary<4488> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
05-23 02:34:28.162+0900 E/EFL     ( 4488): elementary<4488> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
05-23 02:34:28.162+0900 E/EFL     ( 4488): elementary<4488> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
05-23 02:34:28.162+0900 I/AUL_PAD ( 4488): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-23 02:34:28.282+0900 I/efl-extension( 4489): efl_extension.c: eext_mod_init(40) > Init
05-23 02:34:28.302+0900 E/EFL     ( 4489): elementary<4489> elm_main.c:558 elm_quicklaunch_init() eet_init done.
05-23 02:34:28.302+0900 E/EFL     ( 4489): elementary<4489> elm_main.c:560 elm_quicklaunch_init() ecore_init done.
05-23 02:34:28.322+0900 E/EFL     ( 4489): elementary<4489> elm_main.c:572 elm_quicklaunch_init() ecore_file_init done.
05-23 02:34:28.322+0900 I/UXT     ( 4489): Uxt_ObjectManager.cpp: OnInitialized(731) > Initialized.
05-23 02:34:28.322+0900 E/EFL     ( 4489): elementary<4489> elm_main.c:595 elm_quicklaunch_init() _elm_screen_status_init done.
05-23 02:34:28.352+0900 E/EFL     ( 4489): elementary<4489> elm_main.c:625 elm_quicklaunch_init() e_dbus_init done.
05-23 02:34:28.352+0900 E/EFL     ( 4489): elementary<4489> elm_main.c:649 elm_quicklaunch_sub_init() evas_init done.
05-23 02:34:28.352+0900 E/EFL     ( 4489): elementary<4489> elm_main.c:651 elm_quicklaunch_sub_init() edje_init done.
05-23 02:34:28.352+0900 E/EFL     ( 4489): elementary<4489> elm_main.c:653 elm_quicklaunch_sub_init() _elm_module_init done.
05-23 02:34:28.352+0900 E/EFL     ( 4489): elementary<4489> elm_config.c:2749 _elm_config_init() _elm_config_init step 1 done.
05-23 02:34:28.372+0900 I/AUL_AMD (  929): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 4488
05-23 02:34:28.392+0900 E/EFL     ( 4489): elementary<4489> elm_config.c:2757 _elm_config_init() _elm_config_init step 2 done.
05-23 02:34:28.392+0900 E/EFL     ( 4489): elementary<4489> elm_config.c:2761 _elm_config_init() _elm_config_init step 3 done.
05-23 02:34:28.392+0900 E/EFL     ( 4489): elementary<4489> elm_main.c:655 elm_quicklaunch_sub_init() _elm_config_init done.
05-23 02:34:28.412+0900 E/EFL     ( 4489): elementary<4489> elm_config.c:2801 _elm_config_sub_init() ecore_x_init done.
05-23 02:34:28.422+0900 E/EFL     ( 4489): elementary<4489> elm_config.c:2856 _elm_config_sub_init() _config_sub_apply done.
05-23 02:34:28.422+0900 E/EFL     ( 4489): elementary<4489> elm_main.c:657 elm_quicklaunch_sub_init() _elm_config_sub_init done.
05-23 02:34:28.422+0900 E/EFL     ( 4489): elementary<4489> elm_main.c:659 elm_quicklaunch_sub_init() ecore_evas_init done.
05-23 02:34:28.422+0900 E/EFL     ( 4489): elementary<4489> elm_main.c:666 elm_quicklaunch_sub_init() ecore_con_init done.
05-23 02:34:28.422+0900 E/EFL     ( 4489): elementary<4489> elm_main.c:668 elm_quicklaunch_sub_init() ecore_con_url_init done.
05-23 02:34:28.422+0900 E/EFL     ( 4489): elementary<4489> elm_main.c:671 elm_quicklaunch_sub_init() _elm_ews_wm_init done.
05-23 02:34:28.422+0900 I/AUL_PAD ( 4489): launchpad_loader.c: main(580) > [candidate] elm init, returned: 1
05-23 02:34:28.442+0900 I/Adreno-EGL( 4489): <qeglDrvAPI_eglInitialize:410>: EGL 1.4 QUALCOMM build:  ()
05-23 02:34:28.442+0900 I/Adreno-EGL( 4489): OpenGL ES Shader Compiler Version: E031.24.00.16
05-23 02:34:28.442+0900 I/Adreno-EGL( 4489): Build Date: 09/02/15 Wed
05-23 02:34:28.442+0900 I/Adreno-EGL( 4489): Local Branch: 
05-23 02:34:28.442+0900 I/Adreno-EGL( 4489): Remote Branch: 
05-23 02:34:28.442+0900 I/Adreno-EGL( 4489): Local Patches: 
05-23 02:34:28.442+0900 I/Adreno-EGL( 4489): Reconstruct Branch: 
05-23 02:34:28.992+0900 E/PKGMGR_SERVER( 4485): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
05-23 02:34:29.522+0900 E/rpm-installer( 4486): installer-util.c: _installer_util_get_configuration_value(331) > [signature]=[on]
05-23 02:34:30.992+0900 E/PKGMGR_SERVER( 4485): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=0, queue_status=1] 
05-23 02:34:32.632+0900 W/WATCH_CORE( 4295): appcore-watch.c: __signal_lcd_status_handler(1131) > signal_lcd_status_signal: LCDOff
05-23 02:34:32.632+0900 I/WATCH_CORE( 4295): appcore-watch.c: __signal_lcd_status_handler(1135) > Skip the background tick update
05-23 02:34:32.632+0900 W/WAKEUP-SERVICE( 1445): WakeupService.cpp: OnReceiveDisplayChanged(977) > [0;32mINFO: LCDOff receive data : -1226691828[0;m
05-23 02:34:32.632+0900 W/WAKEUP-SERVICE( 1445): WakeupService.cpp: OnReceiveDisplayChanged(978) > [0;32mINFO: WakeupServiceStop[0;m
05-23 02:34:32.632+0900 W/WAKEUP-SERVICE( 1445): WakeupService.cpp: WakeupServiceStop(406) > [0;32mINFO: SEAMLESS WAKEUP STOP REQUEST[0;m
05-23 02:34:32.632+0900 I/TIZEN_N_SOUND_MANAGER( 1445): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1230) > [SVOICE] Wake up Disable start
05-23 02:34:32.642+0900 W/W_HOME  ( 1252): dbus.c: _dbus_message_recv_cb(204) > LCD off
05-23 02:34:32.642+0900 W/W_HOME  ( 1252): gesture.c: _manual_render_disable_timer_del(151) > timer del
05-23 02:34:32.642+0900 W/W_HOME  ( 1252): gesture.c: _manual_render_enable(133) > 1
05-23 02:34:32.642+0900 W/W_HOME  ( 1252): event_manager.c: _lcd_off_cb(699) > lcd state: 0
05-23 02:34:32.642+0900 W/W_HOME  ( 1252): event_manager.c: _state_control(194) > control:4, app_state:1 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-23 02:34:32.642+0900 W/STARTER ( 1145): clock-mgr.c: _on_lcd_signal_receive_cb(1542) > [_on_lcd_signal_receive_cb:1542] _on_lcd_signal_receive_cb, 1542, Pre LCD off by [timeout]
05-23 02:34:32.642+0900 W/STARTER ( 1145): clock-mgr.c: _pre_lcd_off(1326) > [_pre_lcd_off:1326] Will LCD OFF as wake_up_setting[1]
05-23 02:34:32.642+0900 E/STARTER ( 1145): scontext_util.c: scontext_util_handle_lock_state(64) > [scontext_util_handle_lock_state:64] wear state[0],bPossible [0]
05-23 02:34:32.642+0900 W/STARTER ( 1145): clock-mgr.c: _check_reserved_popup_status(256) > [_check_reserved_popup_status:256] Current reserved apps status : 0
05-23 02:34:32.642+0900 W/STARTER ( 1145): clock-mgr.c: _check_reserved_apps_status(292) > [_check_reserved_apps_status:292] Current reserved apps status : 0
05-23 02:34:32.652+0900 I/TIZEN_N_SOUND_MANAGER( 1445): sound_manager_product.c: sound_manager_svoice_wakeup_enable(1233) > [SVOICE] Wake up Disable end. (ret: 0x0)
05-23 02:34:32.652+0900 W/TIZEN_N_SOUND_MANAGER( 1445): sound_manager_private.c: __convert_sound_manager_error_code(96) > [sound_manager_svoice_wakeup_enable] ERROR_NONE (0x00000000)
05-23 02:34:32.652+0900 W/WAKEUP-SERVICE( 1445): WakeupService.cpp: WakeupSetSeamlessValue(369) > [0;32mINFO: WAKEUP SET : 0[0;m
05-23 02:34:32.652+0900 I/HIGEAR  ( 1445): WakeupService.cpp: WakeupServiceStop(410) > [svoice:Application:WakeupServiceStop:IN]
05-23 02:34:32.842+0900 I/SHealth_Common( 1542): SystemUtil.cpp: OnDeviceStatusChanged(679) > [1;35mlcdState:3[0;m
05-23 02:34:32.842+0900 I/SHealth_Service( 1542): SHealthServiceController.cpp: OnSystemUtilLcdStateChanged(676) > [1;35m ###[0;m
05-23 02:34:32.852+0900 W/STARTER ( 1145): clock-mgr.c: _on_lcd_signal_receive_cb(1553) > [_on_lcd_signal_receive_cb:1553] _on_lcd_signal_receive_cb, 1553, Post LCD off by [timeout]
05-23 02:34:32.852+0900 W/STARTER ( 1145): clock-mgr.c: _post_lcd_off(1452) > [_post_lcd_off:1452] LCD OFF as reserved app[(null)] alpm mode[0]
05-23 02:34:32.852+0900 W/STARTER ( 1145): clock-mgr.c: _post_lcd_off(1459) > [_post_lcd_off:1459] Current reserved apps status : 0
05-23 02:34:32.852+0900 W/STARTER ( 1145): clock-mgr.c: _post_lcd_off(1477) > [_post_lcd_off:1477] raise homescreen after 20 sec. home_visible[1]
05-23 02:34:32.852+0900 I/APP_CORE( 1252): appcore-efl.c: __do_app(429) > [APP 1252] Event: PAUSE State: RUNNING
05-23 02:34:32.852+0900 I/CAPI_APPFW_APPLICATION( 1252): app_main.c: app_appcore_pause(202) > app_appcore_pause
05-23 02:34:32.852+0900 W/W_HOME  ( 1252): main.c: _appcore_pause_cb(692) > appcore pause
05-23 02:34:32.852+0900 W/W_HOME  ( 1252): event_manager.c: _app_pause_cb(372) > state: 1 -> 2
05-23 02:34:32.852+0900 W/W_HOME  ( 1252): event_manager.c: _state_control(194) > control:2, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-23 02:34:32.852+0900 W/W_HOME  ( 1252): event_manager.c: _state_control(194) > control:0, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-23 02:34:32.852+0900 W/W_HOME  ( 1252): main.c: home_pause(762) > clock/widget paused
05-23 02:34:32.852+0900 W/W_HOME  ( 1252): event_manager.c: _state_control(194) > control:1, app_state:2 win_state:0(1) pm_state:0 home_visible:1 clock_visible:1 tutorial_state:0 editing : 0, home_clocklist:0, addviewer:0 scrolling : 0, powersaving : 0, apptray state : 1, apptray visibility : 0, apptray edit visibility : 0
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnCheckRemotePort(115) > _MessagePortStub::OnCheckRemotePort.
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: CheckRemotePort(207) > _MessagePortService::CheckRemotePort
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: CheckRemotePort(220) > Check a remote message port: [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: OnReadMessage(739) > _MessagePortIpcServer::OnReadMessage
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: HandleReceivedMessage(578) > _MessagePortIpcServer::HandleReceivedMessage
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnIpcRequestReceived(147) > MessagePort message received
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: OnSendMessage(126) > MessagePort OnSendMessage
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: SendMessage(291) > _MessagePortService::SendMessage
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: GetKey(365) > _MessagePortService::GetKey
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortService.cpp: SendMessage(299) > Sends a message to a remote message port [com.samsung.w-music-player.music-control-service:music-control-service-request-message-port]
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortStub.cpp: SendMessage(138) > MessagePort SendMessage
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: SendResponse(884) > _MessagePortIpcServer::SendResponse
05-23 02:34:32.852+0900 I/MESSAGE_PORT(  873): MessagePortIpcServer.cpp: Send(847) > _MessagePortIpcServer::Stop
05-23 02:34:32.852+0900 I/GESTURE (  260): gesture.c: BackGestureSetProperty(4478) > [BackGestureSetProperty] atom=_E_MOVE_W_HOME_CLOCK_STATE, value=0, No clock display 
05-23 02:34:32.892+0900 E/WMS     (  924): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, PROCESSING]
05-23 02:34:32.912+0900 E/PKGMGR_SERVER( 4485): pkgmgr-server.c: sighandler(409) > child NORMAL exit [4486]
05-23 02:34:32.932+0900 E/WMS     (  924): wms_event_handler.c: _wms_event_handler_cb_log_package(4563) > package [_________] callback : [UPDATE, COMPLETED]
05-23 02:34:32.932+0900 E/WMS     (  924): wms_event_handler.c: _wms_event_handler_cb_package_manager_event(6946) > package install complete
05-23 02:34:32.932+0900 E/WMS     (  924): wms_event_handler.c: _wms_event_handler_package_install_event(4818) > 
05-23 02:34:32.932+0900 E/WMS     (  924): wms_event_handler.c: _wms_event_handler_get_index_from_install_req_list(1758) > Found in install_req_list?[0], index[-1]
05-23 02:34:32.992+0900 E/PKGMGR_SERVER( 4485): pkgmgr-server.c: exit_server(1333) > exit_server Start [backend_status=1, queue_status=1] 
05-23 02:34:32.992+0900 E/PKGMGR_SERVER( 4485): pkgmgr-server.c: main(2185) > package manager server terminated.
05-23 02:34:33.042+0900 W/W_HOME  ( 1252): clock_event.c: _pkgmgr_event_cb(238) > Pkg:org.example.stemwatch is updated, need to check validation
05-23 02:34:33.042+0900 W/W_HOME  ( 1252): clock_event.c: _pkgmgr_event_cb(242) > attacheck clock:org.example.stemwatch
05-23 02:34:33.052+0900 E/STARTER ( 1145): pkg-monitor.c: _pkg_monitor_get_metadata(127) > [_pkg_monitor_get_metadata:127] Failed to get metadata value[-2]
05-23 02:34:33.052+0900 W/W_HOME  ( 1252): clock_event.c: _pkgmgr_event_cb(249) > clock org.example.stemwatch is updated, preload:0 update:0 event->update:0
05-23 02:34:33.072+0900 E/APPS    ( 1252): pkgmgr.c: _update_app(727) >  (!item) -> _update_app() return
05-23 02:34:33.082+0900 E/PKGMGR_INFO(  921): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(848) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
05-23 02:34:33.092+0900 W/MUSIC_CONTROL_SERVICE( 1490): music-control-consumer-control.c: _music_control_consumer_display_state_changed_cb(471) > [36m[TID:1490]   [MUSIC_PLAYER_EVENT]DISPLAY_STATE_SCREEN_OFF[0m
05-23 02:34:33.092+0900 E/CAPI_APPFW_APP_CONTROL( 1490): app_control.c: app_control_error(131) > [app_control_get_caller] INVALID_PARAMETER(0xffffffea) : invalid app_control handle type
05-23 02:34:33.092+0900 W/MUSIC_CONTROL_SERVICE( 1490): music-control-service.c: _music_control_service_pasre_request(437) > [33m[TID:1490]   [com.samsung.w-home]register msg port [false][0m
05-23 02:34:33.092+0900 W/AUL_AMD (  929): amd_request.c: __request_handler(646) > __request_handler: 14
05-23 02:34:33.092+0900 W/AUL_AMD (  929): amd_request.c: __send_result_to_client(83) > __send_result_to_client, pid: 1459
05-23 02:34:33.292+0900 W/AUL_AMD (  929): amd_request.c: __request_handler(646) > __request_handler: 4
05-23 02:34:33.292+0900 E/AUL_AMD (  929): amd_request.c: __app_process_by_pid(193) > pid(4295) is dead. cmd(4) is canceled
05-23 02:34:33.292+0900 W/AUL_AMD (  929): amd_request.c: __request_handler(646) > __request_handler: 0
05-23 02:34:33.302+0900 I/AUL_AMD (  929): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-23 02:34:33.312+0900 I/AUL_AMD (  929): menu_db_util.h: _get_app_info_from_db_by_apppath(239) > path : /usr/bin/data-provider-master, ret : 0
05-23 02:34:33.312+0900 E/AUL_AMD (  929): amd_launch.c: _start_app(1692) > no caller appid info, ret: -1
05-23 02:34:33.312+0900 W/AUL_AMD (  929): amd_launch.c: _start_app(1702) > caller pid : 1206
05-23 02:34:33.322+0900 W/AUL_AMD (  929): amd_launch.c: _start_app(2080) > pad pid(-5)
05-23 02:34:33.322+0900 W/AUL_PAD ( 1647): launchpad.c: __launchpad_main_loop(607) > Candidate is not prepared, enter legacy logic
05-23 02:34:33.322+0900 W/AUL_PAD ( 1647): launchpad.c: __send_result_to_caller(272) > Check app launching
05-23 02:34:33.322+0900 W/AUL_AMD (  929): amd_launch.c: _start_app(2091) > Launch with legacy way : no launchpad
05-23 02:34:33.322+0900 W/AUL_AMD (  929): amd_launch.c: start_process(580) > child process: 4497
05-23 02:34:33.342+0900 E/RESOURCED(  931): block.c: block_prelaunch_state(134) > [block_prelaunch_state,134] insert data org.example.stemwatch, table num : 6
05-23 02:34:33.342+0900 E/RESOURCED(  931): heart-memory.c: heart_memory_get_data(601) > [heart_memory_get_data,601] hashtable heart_memory_app_list is NULL
05-23 02:34:33.352+0900 I/APP_CORE( 1252): appcore-efl.c: __do_app(429) > [APP 1252] Event: MEM_FLUSH State: PAUSED
05-23 02:34:33.372+0900 W/AUL_AMD (  929): amd_launch.c: __send_app_launch_signal(379) > send launch signal done: 4497
05-23 02:34:33.372+0900 I/AUL_AMD (  929): amd_main.c: __app_dead_handler(261) > __app_dead_handler, pid: 4295
05-23 02:34:33.382+0900 E/AUL     (  929): app_signal.c: __app_dbus_signal_filter(89) > reject by security issue - no interface
05-23 02:34:33.422+0900 W/CRASH_MANAGER( 4492): worker.c: worker_job(1199) > 1104295737465146393847
