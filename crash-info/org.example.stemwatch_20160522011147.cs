S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160222.0926
Build-Date: 2016.02.22 09:26:37

Crash Information
Process Name: stemwatch
PID: 2550
Date: 2016-05-22 01:11:47+0900
Executable File Path: /opt/usr/apps/org.example.stemwatch/bin/stemwatch
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x64

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xbfafffa7, esi = 0xbfb001ef
ebp = 0x00000000, esp = 0xbfafff9b
eax = 0xb453bfaf, ebx = 0xb410fa27
ecx = 0x00000001, edx = 0xbfb00024
eip = 0xb410d48e

Memory Information
MemTotal:      124 KB
MemFree:        63 KB
Buffers:         2 KB
Cached:     131920 KB
VmPeak:      89128 KB
VmSize:      89128 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15860 KB
VmRSS:       15860 KB
VmData:      29032 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       32108 KB
VmPTE:          80 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 2550 TID = 2550
2550 2555 2561 

Maps Information
b344f000 b3451000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnu-i686-1.7.99/module.so
b3452000 b3476000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b3697000 b36a5000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b36a6000 b36a9000 r-xp /usr/lib/evas/modules/engines/buffer/linux-gnu-i686-1.7.99/module.so
b36aa000 b36ad000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b3eb2000 b3eb5000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3eb6000 b3ebf000 r-xp /usr/lib/libtbm.so.1.0.0
b3ec0000 b3ec6000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3ec7000 b3ed2000 r-xp /usr/lib/libdrm.so.2.4.0
b3ed3000 b3f05000 r-xp /usr/lib/libsystemd.so.0.0.1
b3f08000 b3f10000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3f11000 b3f2b000 r-xp /usr/lib/libwidget_provider.so.1.0.0
b3f2c000 b3f4c000 r-xp /usr/lib/libwidget_service.so.1.0.0
b3f4d000 b3f69000 r-xp /usr/lib/libcom-core.so.0.0.1
b3f6a000 b40ae000 r-xp /usr/lib/libcairo.so.2.11200.14
b40b2000 b40c1000 r-xp /usr/lib/libwidget.so.1.0.0
b40c2000 b40ce000 r-xp /usr/lib/libwidget_provider_app.so.1.0.0
b40cf000 b40e2000 r-xp /usr/lib/libalarm.so.0.0.0
b40e4000 b4105000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4106000 b410f000 r-xp /usr/lib/libappcore-watch.so.1.1
b4110000 b411b000 r-xp /lib/libnss_files-2.13.so
b435c000 b4383000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4384000 b43a9000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b43aa000 b44cb000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b44db000 b4511000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4513000 b4516000 r-xp /usr/lib/libiniparser.so.0
b4518000 b4522000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0
b4523000 b452c000 r-xp /usr/lib/libappsvc.so.0.1.0
b452d000 b4530000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4533000 b4536000 r-xp /usr/lib/libdri2.so.0.0.0
b4537000 b4539000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b453a000 b453e000 r-xp /opt/usr/apps/org.example.stemwatch/bin/stemwatch
b453f000 b4545000 r-xp /usr/lib/libogg.so.0.7.1
b4546000 b4571000 r-xp /usr/lib/libvorbis.so.0.4.3
b4572000 b465d000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b466b000 b466d000 r-xp /usr/lib/libXau.so.6.0.0
b466e000 b46ce000 r-xp /usr/lib/libssl.so.1.0.0
b46d3000 b4704000 r-xp /usr/lib/libidn.so.11.5.44
b4705000 b4715000 r-xp /usr/lib/libcares.so.2.1.0
b4716000 b477f000 r-xp /usr/lib/libsndfile.so.1.0.25
b4785000 b478f000 r-xp /usr/lib/libsensord-share.so
b4790000 b47b6000 r-xp /lib/libexpat.so.1.5.2
b47b8000 b47df000 r-xp /usr/lib/libpng12.so.0.50.0
b47e0000 b4800000 r-xp /usr/lib/libxcb.so.1.1.0
b4801000 b4870000 r-xp /usr/lib/libcurl.so.4.3.0
b4872000 b487d000 r-xp /usr/lib/libethumb.so.1.7.99
b5ddd000 b5eb5000 r-xp /usr/lib/libstdc++.so.6.0.16
b5ec1000 b5ec4000 r-xp /usr/lib/libctxdata.so.0.0.0
b5ec5000 b5edb000 r-xp /usr/lib/libremix.so.0.0.0
b5edc000 b5ede000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5edf000 b5f0b000 r-xp /usr/lib/liblua-5.1.so
b5f0c000 b5f16000 r-xp /usr/lib/libembryo.so.1.7.99
b5f17000 b5f5d000 r-xp /usr/lib/libjpeg.so.8.0.2
b5f6e000 b5f8c000 r-xp /usr/lib/libsensor.so.1.1.0
b5f8e000 b6010000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6015000 b6049000 r-xp /usr/lib/libfontconfig.so.1.5.0
b604b000 b60a6000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b60a8000 b60be000 r-xp /usr/lib/libfribidi.so.0.3.1
b60bf000 b614b000 r-xp /usr/lib/libfreetype.so.6.11.3
b614f000 b6152000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6153000 b6159000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b615a000 b6160000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6162000 b6173000 r-xp /usr/lib/libXext.so.6.4.0
b6174000 b62a8000 r-xp /usr/lib/libX11.so.6.3.0
b62ac000 b62b1000 r-xp /usr/lib/libXtst.so.6.1.0
b62b2000 b62ba000 r-xp /usr/lib/libXrender.so.1.3.0
b62bb000 b62c4000 r-xp /usr/lib/libXrandr.so.2.2.0
b62c5000 b62c7000 r-xp /usr/lib/libXinerama.so.1.0.0
b62c8000 b62d6000 r-xp /usr/lib/libXi.so.6.1.0
b62d7000 b62db000 r-xp /usr/lib/libXfixes.so.3.1.0
b62dc000 b62de000 r-xp /usr/lib/libXgesture.so.7.0.0
b62df000 b62e1000 r-xp /usr/lib/libXcomposite.so.1.0.0
b62e2000 b62e4000 r-xp /usr/lib/libXdamage.so.1.1.0
b62e5000 b62ee000 r-xp /usr/lib/libXcursor.so.1.0.2
b62ef000 b631a000 r-xp /usr/lib/libecore_con.so.1.7.99
b631c000 b6324000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6325000 b6330000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6331000 b6337000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6338000 b6359000 r-xp /usr/lib/libefreet.so.1.7.99
b635b000 b6367000 r-xp /usr/lib/libedbus.so.1.7.99
b6368000 b64c7000 r-xp /usr/lib/libicuuc.so.51.1
b64d5000 b66de000 r-xp /usr/lib/libicui18n.so.51.1
b66e7000 b6784000 r-xp /usr/lib/libedje.so.1.7.99
b6786000 b6797000 r-xp /usr/lib/libecore_input.so.1.7.99
b6798000 b679f000 r-xp /usr/lib/libecore_file.so.1.7.99
b67a0000 b67c6000 r-xp /usr/lib/libeet.so.1.7.99
b67cf000 b68f7000 r-xp /usr/lib/libevas.so.1.7.99
b6914000 b6947000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6949000 b698d000 r-xp /usr/lib/libecore_x.so.1.7.99
b698f000 b6b89000 r-xp /usr/lib/libelementary.so.1.7.99
b6b9a000 b6ba0000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6ba1000 b6ba5000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6ba9000 b6baa000 r-xp /usr/lib/libjournal.so.0.1.0
b6bab000 b6cf3000 r-xp /usr/lib/libxml2.so.2.7.8
b6cfa000 b6d0d000 r-xp /lib/libresolv-2.13.so
b6d11000 b6d2e000 r-xp /lib/libz.so.1.2.5
b6d2f000 b6d32000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d33000 b6d38000 r-xp /usr/lib/libffi.so.5.0.10
b6d39000 b6d3a000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d3c000 b6d40000 r-xp /lib/libattr.so.1.1.0
b6d41000 b6f53000 r-xp /usr/lib/libcrypto.so.1.0.0
b6f6e000 b6f8f000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6f90000 b6fb8000 r-xp /lib/libm-2.13.so
b6fba000 b7015000 r-xp /usr/lib/libeina.so.1.7.99
b7018000 b7023000 r-xp /usr/lib/libvconf.so.0.2.45
b7024000 b7027000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b7028000 b7076000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b7077000 b71d8000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b71dc000 b71e3000 r-xp /lib/librt-2.13.so
b71e6000 b71ed000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b71ef000 b7209000 r-xp /lib/libgcc_s-4.6.4.so.1
b720a000 b7212000 r-xp /lib/libcrypt-2.13.so
b723b000 b723f000 r-xp /lib/libcap.so.2.21
b7240000 b7242000 r-xp /usr/lib/libiri.so
b7244000 b7270000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b7271000 b7291000 r-xp /usr/lib/libecore.so.1.7.99
b72a0000 b72a9000 r-xp /usr/lib/libxdgmime.so.1.1.0
b72aa000 b73cd000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b73ce000 b73e1000 r-xp /usr/lib/libail.so.0.1.0
b73e3000 b7408000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b7409000 b7413000 r-xp /lib/libunwind.so.8.0.1
b741d000 b758e000 r-xp /lib/libc-2.13.so
b7594000 b75de000 r-xp /usr/lib/libdbus-1.so.3.7.2
b75df000 b75e4000 r-xp /usr/lib/libbundle.so.0.1.22
b75e5000 b75e8000 r-xp /lib/libdl-2.13.so
b75eb000 b75f0000 r-xp /usr/lib/libsmack.so.1.0.0
b75f1000 b7699000 r-xp /usr/lib/libsqlite3.so.0.8.6
b769c000 b76b6000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76b7000 b76ce000 r-xp /lib/libpthread-2.13.so
b76d2000 b76d5000 r-xp /usr/lib/libdlog.so.0.0.0
b76d6000 b76e6000 r-xp /usr/lib/libaul.so.0.1.0
b76e8000 b76ee000 r-xp /usr/lib/libappcore-common.so.1.1
b76ef000 b76f4000 r-xp /usr/lib/libappcore-efl.so.1.1
b76f6000 b76fb000 r-xp /usr/lib/libsys-assert.so
b76fe000 b771c000 r-xp /lib/ld-2.13.so
b771c000 b771d000 r-xp [vdso]
b771f000 b7726000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:2550)
Call Stack Count: 1
 0: (0xb410d48e) [/usr/lib/libappcore-watch.so.1] + 0x748e
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
g.example.stemwatch]
05-22 01:11:47.247+0900 D/rpm-installer( 2581): rpm-appcore-intf.c: main(128) > device_power_lock_state(POWER_LOCK_CPU, 0), ret = [0]
05-22 01:11:47.247+0900 D/rpm-installer( 2581): rpm-appcore-intf.c: main(136) > signature verification mode is [off]
05-22 01:11:47.247+0900 D/rpm-installer( 2581): rpm-cmdline.c: __ri_process_request(282) > coretpk-reinstall org.example.stemwatch
05-22 01:11:47.247+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_package_reinstall(3302) > [#]start : _coretpk_installer_package_reinstall[org.example.stemwatch]
05-22 01:11:47.247+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_read_rds_file(3248) > RDS_STATE_DELETE data : #delete
05-22 01:11:47.247+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_read_rds_file(3253) > RDS_STATE_ADD data : #add
05-22 01:11:47.247+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_read_rds_file(3258) > RDS_STATE_MODIFY data : #modify
05-22 01:11:47.247+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_read_rds_file(3258) > RDS_STATE_MODIFY data : author-signature.xml
05-22 01:11:47.247+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_read_rds_file(3258) > RDS_STATE_MODIFY data : signature1.xml
05-22 01:11:47.247+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_read_rds_file(3258) > RDS_STATE_MODIFY data : bin/stemwatch
05-22 01:11:47.247+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_handle_rds_data(3184) > #[modify] success : author-signature.xml
05-22 01:11:47.247+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_handle_rds_data(3184) > #[modify] success : signature1.xml
05-22 01:11:47.247+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_handle_rds_data(3184) > #[modify] success : bin/stemwatch
05-22 01:11:47.247+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_package_reinstall(3311) > #RDS file reading success
05-22 01:11:47.257+0900 D/PKGMGR  ( 2404): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / start / update
05-22 01:11:47.257+0900 D/PKGMGR  ( 2404): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[start] val[update]
05-22 01:11:47.257+0900 D/PKGMGR  ( 2404): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.257+0900 D/PKGMGR  ( 2404): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.257+0900 D/PKGMGR  ( 2301): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / start / update
05-22 01:11:47.257+0900 D/PKGMGR  ( 2301): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[start] val[update]
05-22 01:11:47.257+0900 D/DATA_PROVIDER_MASTER( 2301): pkgmgr.c: start_cb(201) > [SECURE_LOG] [org.example.stemwatch] update
05-22 01:11:47.257+0900 D/DATA_PROVIDER_MASTER( 2301): package.c: update_cb(1503) > [SECURE_LOG] Update slave state : 0xb8c494a0
05-22 01:11:47.257+0900 D/PKGMGR  ( 2301): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.257+0900 D/PKGMGR  ( 2301): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.257+0900 D/PKGMGR  ( 2305): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / start / update
05-22 01:11:47.257+0900 D/PKGMGR  ( 2305): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[start] val[update]
05-22 01:11:47.257+0900 D/PKGMGR  ( 2305): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.257+0900 D/PKGMGR  ( 2305): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.257+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / start / update
05-22 01:11:47.257+0900 D/PKGMGR  ( 2277): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[start] val[update]
05-22 01:11:47.257+0900 D/ADD_VIEWER( 2277): add-viewer_pkgmgr.c: start_cb(212) > [SECURE_LOG] [org.example.stemwatch] update
05-22 01:11:47.257+0900 D/ADD_VIEWER( 2277): add-viewer_package.c: widget_del_by_pkgid_cb(468) > [SECURE_LOG] Del [org.example.stemwatch]
05-22 01:11:47.257+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.257+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.257+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / start / update
05-22 01:11:47.257+0900 D/PKGMGR  ( 2277): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[start] val[update]
05-22 01:11:47.257+0900 D/W_HOME  ( 2277): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.stemwatch key:start val:update
05-22 01:11:47.257+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.257+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.257+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / start / update
05-22 01:11:47.257+0900 D/PKGMGR  ( 2277): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[start] val[update]
05-22 01:11:47.257+0900 D/APPS    ( 2277): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [start:update] for org.example.stemwatch
05-22 01:11:47.257+0900 D/APPS    ( 2277): pkgmgr.c: _start(435) >  package [org.example.stemwatch], val [update]
05-22 01:11:47.257+0900 D/APPS    ( 2277): pkgmgr.c: _start_update(380) >  Start updating for the package(org.example.stemwatch)
05-22 01:11:47.257+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.257+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.257+0900 D/PKGMGR  ( 2259): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / start / update
05-22 01:11:47.257+0900 D/PKGMGR  ( 2259): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[start] val[update]
05-22 01:11:47.257+0900 D/PKGMGR  ( 2259): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.257+0900 D/PKGMGR  ( 2259): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.257+0900 D/PKGMGR  ( 2186): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [upgrade] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / start / update
05-22 01:11:47.257+0900 D/PKGMGR  ( 2186): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[start] val[update]
05-22 01:11:47.257+0900 D/AUL_AMD ( 2186): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.example.stemwatch), key(start), value(update)
05-22 01:11:47.257+0900 D/AUL_AMD ( 2186): amd_appinfo.c: __amd_pkgmgrinfo_start_handler(442) > [SECURE_LOG] pkgmgr working for this application(org.example.stemwatch)
05-22 01:11:47.257+0900 D/AUL_AMD ( 2186): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(556) > __amd_pkgmgrinfo_start_handler
05-22 01:11:47.257+0900 D/PKGMGR  ( 2186): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.257+0900 D/PKGMGR  ( 2186): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.267+0900 D/PKGMGR  ( 2404): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / install_percent / 30
05-22 01:11:47.267+0900 D/PKGMGR  ( 2404): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[install_percent] val[30]
05-22 01:11:47.267+0900 D/PKGMGR  ( 2404): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.267+0900 D/PKGMGR  ( 2404): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.267+0900 D/PKGMGR  ( 2301): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / install_percent / 30
05-22 01:11:47.267+0900 D/PKGMGR  ( 2301): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[install_percent] val[30]
05-22 01:11:47.267+0900 D/DATA_PROVIDER_MASTER( 2301): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.stemwatch] 30
05-22 01:11:47.267+0900 D/PKGMGR  ( 2301): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.267+0900 D/PKGMGR  ( 2301): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.267+0900 D/PKGMGR  ( 2305): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / install_percent / 30
05-22 01:11:47.267+0900 D/PKGMGR  ( 2305): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[install_percent] val[30]
05-22 01:11:47.267+0900 D/PKGMGR  ( 2305): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.267+0900 D/PKGMGR  ( 2305): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.267+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / install_percent / 30
05-22 01:11:47.267+0900 D/PKGMGR  ( 2277): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[install_percent] val[30]
05-22 01:11:47.267+0900 D/ADD_VIEWER( 2277): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.stemwatch] 30
05-22 01:11:47.267+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.267+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.267+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / install_percent / 30
05-22 01:11:47.267+0900 D/PKGMGR  ( 2277): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[install_percent] val[30]
05-22 01:11:47.267+0900 D/W_HOME  ( 2277): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.stemwatch key:install_percent val:30
05-22 01:11:47.267+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.267+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.267+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / install_percent / 30
05-22 01:11:47.267+0900 D/PKGMGR  ( 2277): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[install_percent] val[30]
05-22 01:11:47.267+0900 D/APPS    ( 2277): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:30] for org.example.stemwatch
05-22 01:11:47.267+0900 D/APPS    ( 2277): pkgmgr.c: _install_percent(469) >  package(org.example.stemwatch) with 30
05-22 01:11:47.267+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.267+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.267+0900 D/PKGMGR  ( 2259): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / install_percent / 30
05-22 01:11:47.267+0900 D/PKGMGR  ( 2259): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[install_percent] val[30]
05-22 01:11:47.267+0900 D/PKGMGR  ( 2259): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.267+0900 D/PKGMGR  ( 2259): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.267+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_package_reinstall(3322) > #Current working directory is /.
05-22 01:11:47.267+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_package_reinstall(3337) > pkgid[org.example.stemwatch]
05-22 01:11:47.267+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_verify_signatures(851) > root_path=[/opt/usr/apps/org.example.stemwatch], pkgid=[org.example.stemwatch]
05-22 01:11:47.267+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_verify_signatures(870) > author-signature.xml is found, path=[/opt/usr/apps/org.example.stemwatch/author-signature.xml]
05-22 01:11:47.267+0900 D/rpm-installer( 2581): rpm-installer-signature.c: _ri_process_signaturevalue(562) > SignatureValue, len=[350]
05-22 01:11:47.267+0900 D/rpm-installer( 2581): 
05-22 01:11:47.267+0900 D/rpm-installer( 2581): KCD7KLSWHRhLzX90fIkg84YpUxElt8nZhQA3+BTaAY5DpgfJeoBg6ChFkNMOgUW8CFCCYrHlhALf
05-22 01:11:47.267+0900 D/rpm-installer( 2581): rhV9kHyjEKj9Wm9nrSWbdGaAjfxViZxHXBnxtHx2BtADDuubfiBSOqdnnz+QyqAqHtP4neRtDrMp
05-22 01:11:47.267+0900 D/rpm-installer( 2581): gf9Fd/4liDcKR7iPM23H1o8aFGZuuwrpd3aAxh0MMldbugJePUxtQF+/DfESjBOCj3Iv8CO6USfv
05-22 01:11:47.267+0900 D/rpm-installer( 2581): cqnb7n3a/X/CBAN7MqJxt/+e6Vrp7t3aerwIg+iEga6f2+bzF2oOXNvVNBHAKa9xqyohdf8mpHUE
05-22 01:11:47.267+0900 D/rpm-installer( 2581): voqxqch417gjPEDmw/Pw4mfRj/uajepxhWgu8w==
05-22 01:11:47.267+0900 D/rpm-installer( 2581): rpm-installer-signature.c: _ri_process_x509certificate(470) > x509certificate, len=[1238]
05-22 01:11:47.267+0900 D/rpm-installer( 2581): 
05-22 01:11:47.267+0900 D/rpm-installer( 2581): MIIDjTCCAnWgAwIBAgIBATANBgkqhkiG9w0BAQsFADCBsDELMAkGA1UEBhMCS1IxFDASBgNVBAgM
05-22 01:11:47.267+0900 D/rpm-installer( 2581): C1NvdXRoIEtvcmVhMQ4wDAYDVQQHDAVTdXdvbjEmMCQGA1UECgwdU2Ftc3VuZyBFbGVjdHJvbmlj
05-22 01:11:47.267+0900 D/rpm-installer( 2581): cyBDby4sIEx0ZC4xDzANBgNVBAsMBk1vYmlsZTEgMB4GA1UEAwwXU2Ftc3VuZyBBdXRob3IgQ0Eg
05-22 01:11:47.267+0900 D/rpm-installer( 2581): Q2xhc3MxIDAeBgkqhkiG9w0BCQEWEXRpemVuQHNhbXN1bmcuY29tMB4XDTE2MDQwOTA2MTUxOVoX
05-22 01:11:47.267+0900 D/rpm-installer( 2581): DTE3MDQwOTA2MTUxOVowRzEJMAcGA1UEBhMAMQkwBwYDVQQIEwAxCTAHBgNVBAcTADEJMAcGA1UE
05-22 01:11:47.267+0900 D/rpm-installer( 2581): ChMAMQkwBwYDVQQLEwAxDjAMBgNVBAMTBUxlZVNZMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIB
05-22 01:11:47.267+0900 D/rpm-installer( 2581): CgKCAQEAijXtNjirfXF73xTqoWCu12n95arL4rId0XNV9AvuGXlmzl5WnbqXENSeK5RHQ3HnlYip
05-22 01:11:47.267+0900 D/rpm-installer( 2581): 1dMA8KnrfIJj8QtWfPuf89qO86erUqqSqyOl/gVwZCD/kVhalS2MlbWVON1w2vhYHD5iBDiBqQ7f
05-22 01:11:47.267+0900 D/rpm-installer( 2581): Vg4wNFVcsc4BwGU9dgtVbW+h/jpbLLzkBeczTP6P6x94ka8GUSp+x7nzfB3gPvHT0tJezniycUy+
05-22 01:11:47.267+0900 D/rpm-installer( 2581): FqfkDhRhwS1ybIRc9cvpZ6KghT2w5Z5vZpJJ/r+M8I6Z91n+4YVhMMtZjqzEXbeij8fzMEJHxeVr
05-22 01:11:47.267+0900 D/rpm-installer( 2581): F4VUU0OJxm7YBL97VYsgpQQ/wvpGLkPW4GvleBzcZnG/sQIDAQABoxowGDAJBgNVHRMEAjAAMAsG
05-22 01:11:47.267+0900 D/rpm-installer( 2581): A1UdDwQEAwIHgDANBgkqhkiG9w0BAQsFAAOCAQEAVbpmtONbGDPAuz9jOCpGyuI00qqirT2N1PQ+
05-22 01:11:47.267+0900 D/rpm-installer( 2581): bZw+gTZp
05-22 01:11:47.267+0900 D/rpm-installer( 2581): rpm-installer-signature.c: _ri_process_x509certificate(470) > x509certificate, len=[1254]
05-22 01:11:47.267+0900 D/rpm-installer( 2581): 
05-22 01:11:47.267+0900 D/rpm-installer( 2581): MIIDmzCCAoOgAwIBAgICYygwDQYJKoZIhvcNAQELBQAwXjEaMBgGA1UECgwRVGl6ZW4gQXNzb2Np
05-22 01:11:47.267+0900 D/rpm-installer( 2581): YXRpb24xGjAYBgNVBAsMEVRpemVuIEFzc29jaWF0aW9uMSQwIgYDVQQDDBtUaXplbiBEZXZlbG9w
05-22 01:11:47.267+0900 D/rpm-installer( 2581): ZXJzIFJvb3QgQ2xhc3MwHhcNMTMxMjMwMTUwNTU4WhcNMjgxMjI2MTUwNTU4WjCBsDELMAkGA1UE
05-22 01:11:47.267+0900 D/rpm-installer( 2581): BhMCS1IxFDASBgNVBAgMC1NvdXRoIEtvcmVhMQ4wDAYDVQQHDAVTdXdvbjEmMCQGA1UECgwdU2Ft
05-22 01:11:47.267+0900 D/rpm-installer( 2581): c3VuZyBFbGVjdHJvbmljcyBDby4sIEx0ZC4xDzANBgNVBAsMBk1vYmlsZTEgMB4GA1UEAwwXU2Ft
05-22 01:11:47.267+0900 D/rpm-installer( 2581): c3VuZyBBdXRob3IgQ0EgQ2xhc3MxIDAeBgkqhkiG9w0BCQEWEXRpemVuQHNhbXN1bmcuY29tMIIB
05-22 01:11:47.267+0900 D/rpm-installer( 2581): IjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAs+tRBgnKJs8j7BFg8/UftqbqTCYBV3Jrg1vK
05-22 01:11:47.267+0900 D/rpm-installer( 2581): YvEuoTfntYz2uT2SO67raiCsZBAYvJnP54ExkdV++UgB7BDGniWz7bA1pYKak5kNK5jtLQt2DmZX
05-22 01:11:47.267+0900 D/rpm-installer( 2581): 3qgaLjMyoAz+293CxrBQO4h8NaTQGsO/WLpeQq2Y1ZEnHsq+EUn90H6Vm0HNW+KUayGPYdey+QSW
05-22 01:11:47.267+0900 D/rpm-installer( 2581): iiv+L++TSuHrw0b16GYn83emiTnKTCmwpSOZ712Gy9kccl46/K4C8skEDVZjTk9s7r/MN9ZNZsqR
05-22 01:11:47.267+0900 D/rpm-installer( 2581): brT/3AYcrF4ao8ipwlHK91WJBXXaiQICvp/dNfCSDWpTWy7z4XmgP16pSLnfgZlwEwWfiaavHRNM
05-22 01:11:47.267+0900 D/rpm-installer( 2581): mwIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBCwUAA4IBAQB/ZlNMTzlIHqC3mFSq
05-22 01:11:47.267+0900 D/rpm-installer( 2581): ptuQDZG9
05-22 01:11:47.367+0900 D/AUL_AMD ( 2186): amd_launch.c: __grab_timeout_handler(1212) > pid(2550) ecore_x_pointer_ungrab
05-22 01:11:47.367+0900 D/AUL_AMD ( 2186): amd_request.c: __add_history_handler(247) > [SECURE_LOG] add rua history org.example.stemwatch /opt/usr/apps/org.example.stemwatch/bin/stemwatch
05-22 01:11:47.367+0900 D/RUA     ( 2186): rua.c: rua_add_history(179) > rua_add_history start
05-22 01:11:47.377+0900 D/RUA     ( 2186): rua.c: rua_add_history(247) > rua_add_history ok
05-22 01:11:47.597+0900 D/rpm-installer( 2581): rpm-installer.c: _ri_verify_sig_and_cert(1921) > cert_svc_verify() is done successfully. validity=[1]
05-22 01:11:47.597+0900 D/rpm-installer( 2581): rpm-installer.c: _ri_verify_sig_and_cert(1932) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/Tizen_Developers_Root_Class.pem]
05-22 01:11:47.627+0900 D/rpm-installer( 2581): rpm-installer.c: __ri_verify_file(407) > valid signature
05-22 01:11:47.627+0900 D/rpm-installer( 2581): rpm-installer.c: __ri_get_cert_from_file(1066) > Root CA, len=[1136]
05-22 01:11:47.627+0900 D/rpm-installer( 2581): MIIDTzCCAjegAwIBAgIJALddlYde0wE9MA0GCSqGSIb3DQEBCwUAMF4xGjAYBgNVBAoMEVRpemVuIEFzc29jaWF0aW9uMRowGAYDVQQLDBFUaXplbiBBc3NvY2lhdGlvbjEkMCIGA1UEAwwbVGl6ZW4gRGV2ZWxvcGVycyBSb290IENsYXNzMB4XDTEzMTIzMDE1MDQxMFoXDTMzMTIyNTE1MDQxMFowXjEaMBgGA1UECgwRVGl6ZW4gQXNzb2NpYXRpb24xGjAYBgNVBAsMEVRpemVuIEFzc29jaWF0aW9uMSQwIgYDVQQDDBtUaXplbiBEZXZlbG9wZXJzIFJvb3QgQ2xhc3MwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDRUet02YnWItxNZzZc+o2WqH3LrJh70mCY/B9jlw9ckKKABD39glT17KaW+ZKFyN9M3h/wd2SU5g3CkwMMNOIrFLTB3YryR/aH+3ps6c8RqSUJG+6klFOaXuiG0kCzxvwVA+T+8z7zZKeBj6D6AooA6BpKgflu9J94KQqT3/y5IABQLm3SrB4iclabdT3Y+ZEBz63yNcHqJTpjqQw/wB3LV5a0i/Y/MjPn8Oogkgh/edJvIklUXcZC5Ac1tYB+ZZLKvROqUrPyzFOyPMU/EnoXRYX+PBiLtG+34o0Orw31Ifjs/r0AFs5qsLjR37YB9x5IWSwfTJuZcSPtyO1nDeNDAgMBAAGjEDAOMAwGA1UdEwQFMAMBAf8wDQYJKoZIhvcNAQELBQADggEBAJ60YDkQ8IPBZoamDMoxkNlKFxv5azN7eeD5nO1h9ASzz3HI5wa9Iry67l0MBjio3caLHjCnV9KzllXMBNCL6Dv0fBpFUadU57lfX5raH7ELGlpplyj1aVQlHm3zvF8eXGu6zmdS0Vdw/NOGaNuIwm/xUUCkeJyPWM
05-22 01:11:47.627+0900 D/rpm-installer( 2581): rpm-installer.c: _ri_verify_sig_and_cert(1956) > cert_svc_get_visibility() returns visibility=[1]
05-22 01:11:47.627+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_verify_signatures(877) > _ri_verify_sig_and_cert succeed, path=[/opt/usr/apps/org.example.stemwatch/author-signature.xml]
05-22 01:11:47.627+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_verify_signatures(888) > signature1.xml is found, path=[/opt/usr/apps/org.example.stemwatch]
05-22 01:11:47.627+0900 D/rpm-installer( 2581): rpm-installer-signature.c: _ri_process_signaturevalue(562) > SignatureValue, len=[350]
05-22 01:11:47.627+0900 D/rpm-installer( 2581): 
05-22 01:11:47.627+0900 D/rpm-installer( 2581): O6yeHXLJg973Hbwl2pgzl1yHD5H0P4Cp+yrMYaNhfpNVfL0rx/JaSFywTRnvdn+E3pbCjyGksotr
05-22 01:11:47.627+0900 D/rpm-installer( 2581): whf/o6SO0/gKCLAhA0gYQyyuJSL1ebqOXdhMVebnBvaCSeViZGmgTNbFVL4t+jq4K5Ma+abH+dKs
05-22 01:11:47.627+0900 D/rpm-installer( 2581): SHEYZ+DXx/FluPgpzuVNrpveYQEDXegPRKw/gxd6ypu6R7cncfftRzDM1ZPNuIVKm/zs+Vo3SvYW
05-22 01:11:47.627+0900 D/rpm-installer( 2581): A86khtrGRxQGq27lrb84kLqOf6t1pxCD0QQMvBFk+43FxVS57Nb1F8W01cvvdpPlBxjXe2avOKwg
05-22 01:11:47.627+0900 D/rpm-installer( 2581): IOlrec2bdOgzPBC/+1EgIsJEBQFlnNnPICiZuQ==
05-22 01:11:47.627+0900 D/rpm-installer( 2581): rpm-installer-signature.c: _ri_process_x509certificate(470) > x509certificate, len=[1262]
05-22 01:11:47.627+0900 D/rpm-installer( 2581): 
05-22 01:11:47.627+0900 D/rpm-installer( 2581): MIIDoDCCAoigAwIBAgIBZTANBgkqhkiG9w0BAQsFADCBnjELMAkGA1UEBhMCS1IxFDASBgNVBAgM
05-22 01:11:47.627+0900 D/rpm-installer( 2581): C1NvdXRoIEtvcmVhMQ4wDAYDVQQHDAVTdXdvbjEmMCQGA1UECgwdU2Ftc3VuZyBFbGVjdHJvbmlj
05-22 01:11:47.627+0900 D/rpm-installer( 2581): cyBDby4sIEx0ZC4xDzANBgNVBAsMBk1vYmlsZTEwMC4GA1UEAwwnU2Ftc3VuZyBUaXplbiBERVZF
05-22 01:11:47.627+0900 D/rpm-installer( 2581): TE9QRVIgUHVibGljIENBIENsYXNzMB4XDTE2MDQwOTA2MTkxNFoXDTE3MDQwOTA2MTkxNFowbDER
05-22 01:11:47.627+0900 D/rpm-installer( 2581): MA8GA1UEAwwIVGl6ZW5TREsxCTAHBgNVBAsMADEJMAcGA1UECgwAMQkwBwYDVQQHDAAxCTAHBgNV
05-22 01:11:47.627+0900 D/rpm-installer( 2581): BAgMADEJMAcGA1UEBhMAMSAwHgYJKoZIhvcNAQkBFhFhc3ltNTIzQGdtYWlsLmNvbTCCASIwDQYJ
05-22 01:11:47.627+0900 D/rpm-installer( 2581): KoZIhvcNAQEBBQADggEPADCCAQoCggEBAIBmV/8rUkY9VJopi6boLTMoGCSWg8BS5fZguyV79nGE
05-22 01:11:47.627+0900 D/rpm-installer( 2581): WxorUJPLBZHi1lASsPeBOAHv7nQZAT95N3N4lPUiPKsbJfVyAnQVGKv4B/0GjgsHfoffvHcHQgv3
05-22 01:11:47.627+0900 D/rpm-installer( 2581): 3NKeBS+QVaWkdtJse8HbVEmLnOtpPQBjVtkgd25TO9Ukpcgq1/nvvRXJOzNM8C20/cS9i6eEZ2V2
05-22 01:11:47.627+0900 D/rpm-installer( 2581): k8NJ9n4V4Wduw4Atb+Z6uDec6wvHTLhnl628ftMVW6I2ngBsg/G90Pg6aSA3ReNnlYy+Xhc9cbW1
05-22 01:11:47.627+0900 D/rpm-installer( 2581): ZIMF3B7SKynKxEveWMWeKU8WFrkvGivDeM7gYXeZ8hZ1Su0Cy+yRgrW1lNPiD8tNk2PSjLMCAwEA
05-22 01:11:47.627+0900 D/rpm-installer( 2581): AaMaMBgwCQYDVR0TBAIwADALBgNVHQ8EBAMCB4AwDQYJKoZIhvcNAQELBQADggEBAGkUL0jL4CDz
05-22 01:11:47.627+0900 D/rpm-installer( 2581): KNfouUJT
05-22 01:11:47.627+0900 D/rpm-installer( 2581): rpm-installer-signature.c: _ri_process_x509certificate(470) > x509certificate, len=[1298]
05-22 01:11:47.627+0900 D/rpm-installer( 2581): 
05-22 01:11:47.627+0900 D/rpm-installer( 2581): MIIDuzCCAqOgAwIBAgICL+cwDQYJKoZIhvcNAQELBQAwgY8xCzAJBgNVBAYTAktSMRQwEgYDVQQI
05-22 01:11:47.627+0900 D/rpm-installer( 2581): DAtTb3V0aCBLb3JlYTEOMAwGA1UEBwwFU3V3b24xJjAkBgNVBAoMHVNhbXN1bmcgRWxlY3Ryb25p
05-22 01:11:47.627+0900 D/rpm-installer( 2581): Y3MgQ28uLCBMdGQuMTIwMAYDVQQDDClTYW1zdW5nIFRpemVuIERFVkVMT1BFUiBQdWJsaWMgUm9v
05-22 01:11:47.627+0900 D/rpm-installer( 2581): dCBDbGFzczAeFw0xMzEyMzAxNTAxNDdaFw0yODEyMjYxNTAxNDdaMIGeMQswCQYDVQQGEwJLUjEU
05-22 01:11:47.627+0900 D/rpm-installer( 2581): MBIGA1UECAwLU291dGggS29yZWExDjAMBgNVBAcMBVN1d29uMSYwJAYDVQQKDB1TYW1zdW5nIEVs
05-22 01:11:47.627+0900 D/rpm-installer( 2581): ZWN0cm9uaWNzIENvLiwgTHRkLjEPMA0GA1UECwwGTW9iaWxlMTAwLgYDVQQDDCdTYW1zdW5nIFRp
05-22 01:11:47.627+0900 D/rpm-installer( 2581): emVuIERFVkVMT1BFUiBQdWJsaWMgQ0EgQ2xhc3MwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEK
05-22 01:11:47.627+0900 D/rpm-installer( 2581): AoIBAQCkqW9d0zO5NFOc7u164DKe9Yx+yEgUnsbhnJasqHaqT71qaMxyCOjyysZi7gGycDcgmLcU
05-22 01:11:47.627+0900 D/rpm-installer( 2581): tr2wSMTGWPibK8SrJ8bV/J1cy9nTpljM3s+lbPIVVxZeufhJkU79tXImHLolERd0vui+rj0Xpd9O
05-22 01:11:47.627+0900 D/rpm-installer( 2581): zlyNTRt0+PWVT1taWcbfHL7pUD25hMkTc8C3bC+dUoT1/RhCkXgmUvIor3EnnU0rBtAl4qNtg5y1
05-22 01:11:47.627+0900 D/rpm-installer( 2581): 7RLT8dyicieAHCcW923YC/ngMZxnBjbL2Ht1RBUvrL6K3X5+l0VeF4qC3g7TKm/a/SGjq12ZD4sc
05-22 01:11:47.627+0900 D/rpm-installer( 2581): 7rglzjSNlTVSGag6/2WkqxE6HheEBWaloYOdauzwydFNAgMBAAGjEDAOMAwGA1UdEwQFMAMBAf8w
05-22 01:11:47.627+0900 D/rpm-installer( 2581): DQYJKoZI
05-22 01:11:47.687+0900 D/rpm-installer( 2581): rpm-installer.c: _ri_verify_sig_and_cert(1921) > cert_svc_verify() is done successfully. validity=[1]
05-22 01:11:47.687+0900 D/rpm-installer( 2581): rpm-installer.c: _ri_verify_sig_and_cert(1932) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/samsung_tizen_dev_public.pem]
05-22 01:11:47.707+0900 D/rpm-installer( 2581): rpm-installer.c: __ri_verify_file(407) > valid signature
05-22 01:11:47.707+0900 D/rpm-installer( 2581): rpm-installer.c: __ri_get_cert_from_file(1066) > Root CA, len=[1268]
05-22 01:11:47.707+0900 D/rpm-installer( 2581): MIIDszCCApugAwIBAgIJALxYLI/Z7cqZMA0GCSqGSIb3DQEBCwUAMIGPMQswCQYDVQQGEwJLUjEUMBIGA1UECAwLU291dGggS29yZWExDjAMBgNVBAcMBVN1d29uMSYwJAYDVQQKDB1TYW1zdW5nIEVsZWN0cm9uaWNzIENvLiwgTHRkLjEyMDAGA1UEAwwpU2Ftc3VuZyBUaXplbiBERVZFTE9QRVIgUHVibGljIFJvb3QgQ2xhc3MwHhcNMTMxMjMwMTUwMTQyWhcNMzMxMjI1MTUwMTQyWjCBjzELMAkGA1UEBhMCS1IxFDASBgNVBAgMC1NvdXRoIEtvcmVhMQ4wDAYDVQQHDAVTdXdvbjEmMCQGA1UECgwdU2Ftc3VuZyBFbGVjdHJvbmljcyBDby4sIEx0ZC4xMjAwBgNVBAMMKVNhbXN1bmcgVGl6ZW4gREVWRUxPUEVSIFB1YmxpYyBSb290IENsYXNzMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAsBOg6dthhkQ5vY5QW2KXyMb2bwKqHLUqRj1GkdcOVWJA+rxBnRlfYVVBJv9MCecrLkieriWfHB3Tcn9fIUnGtSzj2X7An5Qg05toNkjuS7B73Pb+eHZ2vEFNmFf+FQBc6KzCg+fSBa63BZg/lQg+l97gSKE1KFzU8D8INWJd/Yn6Uespvmcbyp3nlKakfleVdEsYOQ3HTevPfnoClRYsCI4R5/rFM4h6GzO2X8IEDhLgMc/Q8VWH/CoRkGwww7C//ofutdNs2WCF8FISyiSJq+sDXHlyGXKtZ+7ArKdLpe3xOZGGY2NJOV7H1v0vtJZeJSFPcoVd5csKgURu9v/7twIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBCwUAA4IBAQBY+gZZPQ6MYkIrYB6JmaorVncOwy
05-22 01:11:47.707+0900 D/rpm-installer( 2581): rpm-installer.c: _ri_verify_sig_and_cert(1956) > cert_svc_get_visibility() returns visibility=[64]
05-22 01:11:47.707+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_verify_signatures(895) > _ri_verify_sig_and_cert() succeed, path=[/opt/usr/apps/org.example.stemwatch/signature1.xml]
05-22 01:11:47.707+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_package_reinstall(3345) > signature and certificate verifying success
05-22 01:11:47.707+0900 D/PKGMGR  ( 2404): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / install_percent / 60
05-22 01:11:47.707+0900 D/PKGMGR  ( 2404): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[install_percent] val[60]
05-22 01:11:47.707+0900 D/PKGMGR  ( 2404): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.707+0900 D/PKGMGR  ( 2404): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.707+0900 D/PKGMGR  ( 2301): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / install_percent / 60
05-22 01:11:47.707+0900 D/PKGMGR  ( 2301): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[install_percent] val[60]
05-22 01:11:47.707+0900 D/DATA_PROVIDER_MASTER( 2301): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.example.stemwatch] 60
05-22 01:11:47.707+0900 D/PKGMGR  ( 2301): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.707+0900 D/PKGMGR  ( 2301): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.707+0900 D/PKGMGR  ( 2305): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / install_percent / 60
05-22 01:11:47.707+0900 D/PKGMGR  ( 2305): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[install_percent] val[60]
05-22 01:11:47.707+0900 D/PKGMGR  ( 2305): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.707+0900 D/PKGMGR  ( 2305): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.707+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / install_percent / 60
05-22 01:11:47.707+0900 D/PKGMGR  ( 2277): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[install_percent] val[60]
05-22 01:11:47.707+0900 D/ADD_VIEWER( 2277): add-viewer_pkgmgr.c: progress_cb(385) > [SECURE_LOG] [org.example.stemwatch] 60
05-22 01:11:47.707+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.707+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.707+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / install_percent / 60
05-22 01:11:47.707+0900 D/PKGMGR  ( 2277): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[install_percent] val[60]
05-22 01:11:47.707+0900 D/W_HOME  ( 2277): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.stemwatch key:install_percent val:60
05-22 01:11:47.707+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.707+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.707+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / install_percent / 60
05-22 01:11:47.707+0900 D/PKGMGR  ( 2277): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[install_percent] val[60]
05-22 01:11:47.707+0900 D/APPS    ( 2277): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [install_percent:60] for org.example.stemwatch
05-22 01:11:47.707+0900 D/APPS    ( 2277): pkgmgr.c: _install_percent(469) >  package(org.example.stemwatch) with 60
05-22 01:11:47.707+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.707+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.707+0900 D/PKGMGR  ( 2259): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / coretpk / org.example.stemwatch / install_percent / 60
05-22 01:11:47.707+0900 D/PKGMGR  ( 2259): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[coretpk] pkgid[org.example.stemwatch]key[install_percent] val[60]
05-22 01:11:47.707+0900 D/PKGMGR  ( 2259): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:47.707+0900 D/PKGMGR  ( 2259): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:47.717+0900 E/PKGMGR_CERT( 2581): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(438) > Transaction Begin
05-22 01:11:47.717+0900 E/PKGMGR_CERT( 2581): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 11 8
05-22 01:11:47.717+0900 E/PKGMGR_CERT( 2581): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 12 8
05-22 01:11:47.717+0900 E/PKGMGR_CERT( 2581): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 13 8
05-22 01:11:47.717+0900 E/PKGMGR_CERT( 2581): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 14 8
05-22 01:11:47.717+0900 E/PKGMGR_CERT( 2581): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 15 8
05-22 01:11:47.717+0900 E/PKGMGR_CERT( 2581): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(507) > Id:Count = 16 8
05-22 01:11:47.727+0900 E/PKGMGR_CERT( 2581): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(587) > Transaction Commit and End
05-22 01:11:47.727+0900 E/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_make_directory(1586) > mkdir failed. appdir=[/usr/apps/org.example.stemwatch/shared], errno=[2][No such file or directory]
05-22 01:11:47.727+0900 E/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1219) > skip! empty dirpath=[/usr/apps/org.example.stemwatch/shared]
05-22 01:11:47.727+0900 E/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1219) > skip! empty dirpath=[/usr/apps/org.example.stemwatch/shared/res]
05-22 01:11:47.727+0900 E/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.stemwatch/tizen-manifest.xml]
05-22 01:11:47.727+0900 E/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.stemwatch/author-signature.xml]
05-22 01:11:47.727+0900 E/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/apps/org.example.stemwatch/signature1.xml]
05-22 01:11:47.727+0900 E/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_apply_file_policy(1204) > skip! empty filepath=[/usr/share/packages/org.example.stemwatch.xml]
05-22 01:11:47.727+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1390) > Exist shared/data folder (path:[/opt/usr/apps/org.example.stemwatch/shared/data])
05-22 01:11:47.797+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_unregister_package(84) > [smack] app_uninstall(org.example.stemwatch), result=[0]
05-22 01:11:47.817+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_register_package(64) > [smack] app_install(org.example.stemwatch), result=[0]
05-22 01:11:47.817+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/usr/apps/org.example.stemwatch, 5, _), result=[0]
05-22 01:11:47.817+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/usr/apps/org.example.stemwatch/shared, 5, _), result=[0]
05-22 01:11:47.817+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/usr/apps/org.example.stemwatch/shared/res, 5, _), result=[0]
05-22 01:11:47.847+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.stemwatch, /opt/usr/apps/org.example.stemwatch/shared/data, 2), result=[0]
05-22 01:11:47.847+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_get_group_id(1866) > encoding done, len=[28]
05-22 01:11:47.847+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_apply_smack(1974) > groupid = [jpaVVgKtWYwpxiwab2ahamf4CEo=] for shared/trusted.
05-22 01:11:47.867+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/usr/apps/org.example.stemwatch/shared/trusted, 1, jpaVVgKtWYwpxiwab2ahamf4CEo=), result=[0]
05-22 01:11:47.867+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/usr/apps/org.example.stemwatch/bin, 0, org.example.stemwatch), result=[0]
05-22 01:11:47.867+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/usr/apps/org.example.stemwatch/data, 0, org.example.stemwatch), result=[0]
05-22 01:11:47.867+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/usr/apps/org.example.stemwatch/lib, 0, org.example.stemwatch), result=[0]
05-22 01:11:47.867+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/usr/apps/org.example.stemwatch/res, 0, org.example.stemwatch), result=[0]
05-22 01:11:47.867+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/usr/apps/org.example.stemwatch/cache, 0, org.example.stemwatch), result=[0]
05-22 01:11:47.867+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/usr/apps/org.example.stemwatch/tizen-manifest.xml, 0, org.example.stemwatch), result=[0]
05-22 01:11:47.867+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/usr/apps/org.example.stemwatch/author-signature.xml, 0, org.example.stemwatch), result=[0]
05-22 01:11:47.867+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/usr/apps/org.example.stemwatch/signature1.xml, 0, org.example.stemwatch), result=[0]
05-22 01:11:47.867+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/share/packages/org.example.stemwatch.xml, 0, org.example.stemwatch), result=[0]
05-22 01:11:47.867+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/storage/sdcard/apps/org.example.stemwatch, 5, _), result=[0]
05-22 01:11:47.867+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/storage/sdcard/apps/org.example.stemwatch/data, 0, org.example.stemwatch), result=[0]
05-22 01:11:47.867+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/storage/sdcard/apps/org.example.stemwatch/cache, 0, org.example.stemwatch), result=[0]
05-22 01:11:47.867+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(123) > [smack] app_setup_path(org.example.stemwatch, /opt/storage/sdcard/apps/org.example.stemwatch/shared, 5, _), result=[0]
05-22 01:11:47.897+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_setup_path(120) > [smack] app_setup_path(org.example.stemwatch, /opt/storage/sdcard/apps/org.example.stemwatch/shared/data, 2), result=[0]
05-22 01:11:47.907+0900 D/rpm-installer( 2581): rpm-installer.c: __privilege_func(1086) > package_id = [org.example.stemwatch], privilege = [http://tizen.org/privilege/alarm.set]
05-22 01:11:47.907+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
05-22 01:11:47.907+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.stemwatch, 7), result=[0]
05-22 01:11:47.937+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
05-22 01:11:47.937+0900 D/rpm-installer( 2581): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.example.stemwatch, 7) succeed.
05-22 01:11:47.937+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
05-22 01:11:47.937+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: _ri_privilege_enable_permissions(107) > [smack] app_enable_permissions(org.example.stemwatch, 7), result=[0]
05-22 01:11:47.967+0900 D/rpm-installer( 2581): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
05-22 01:11:47.967+0900 D/rpm-installer( 2581): coretpk-installer.c: _coretpk_installer_package_reinstall(3437) > #permission applying success.
05-22 01:11:47.967+0900 D/PRIVILEGE_MANAGER( 2581): privilege_manager.c: privilege_manager_verify_privilege(160) > privilege_manager_verify_privilege called
05-22 01:11:47.977+0900 D/PKGMGR_SERVER( 2580): pkgmgr-server.c: sighandler(326) > child exit [2581]
05-22 01:11:47.977+0900 D/PKGMGR_SERVER( 2580): pkgmgr-server.c: sighandler(348) > child SIGNALED exit [2581]
05-22 01:11:47.977+0900 D/PKGMGR_SERVER( 2580): pkgmgr-server.c: send_fail_signal(291) > send_fail_signal start
05-22 01:11:47.997+0900 D/WATCH_CORE( 2550): appcore-watch.c: __watch_core_time_tick(834) > state: 2
05-22 01:11:47.997+0900 D/WATCH_CORE( 2550): appcore-watch.c: __watch_core_time_tick(845) > next time tick: 0.999000
05-22 01:11:47.997+0900 I/CAPI_WATCH_APPLICATION( 2550): watch_app_main.c: _watch_core_time_tick(301) > _watch_core_time_tick
05-22 01:11:48.007+0900 D/PKGMGR  ( 2404): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / rpm / org.example.stemwatch / end / fail
05-22 01:11:48.007+0900 D/PKGMGR  ( 2404): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[rpm] pkgid[org.example.stemwatch]key[end] val[fail]
05-22 01:11:48.007+0900 D/PKGMGR  ( 2404): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:48.007+0900 D/PKGMGR  ( 2404): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:48.007+0900 D/PKGMGR  ( 2301): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / rpm / org.example.stemwatch / end / fail
05-22 01:11:48.007+0900 D/PKGMGR  ( 2301): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[rpm] pkgid[org.example.stemwatch]key[end] val[fail]
05-22 01:11:48.007+0900 D/DATA_PROVIDER_MASTER( 2301): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.example.stemwatch] fail
05-22 01:11:48.007+0900 D/PKGMGR  ( 2301): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:48.007+0900 D/PKGMGR  ( 2301): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:48.007+0900 D/PKGMGR  ( 2305): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / rpm / org.example.stemwatch / end / fail
05-22 01:11:48.007+0900 D/PKGMGR  ( 2305): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[rpm] pkgid[org.example.stemwatch]key[end] val[fail]
05-22 01:11:48.007+0900 D/PKGMGR  ( 2305): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:48.007+0900 D/PKGMGR  ( 2305): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:48.007+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / rpm / org.example.stemwatch / end / fail
05-22 01:11:48.007+0900 D/PKGMGR  ( 2277): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[rpm] pkgid[org.example.stemwatch]key[end] val[fail]
05-22 01:11:48.007+0900 D/ADD_VIEWER( 2277): add-viewer_pkgmgr.c: end_cb(420) > [SECURE_LOG] [org.example.stemwatch] fail
05-22 01:11:48.007+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:48.007+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:48.007+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / rpm / org.example.stemwatch / end / fail
05-22 01:11:48.007+0900 D/PKGMGR  ( 2277): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[rpm] pkgid[org.example.stemwatch]key[end] val[fail]
05-22 01:11:48.007+0900 D/W_HOME  ( 2277): clock_event.c: _pkgmgr_event_cb(123) > pkg:org.example.stemwatch key:end val:fail
05-22 01:11:48.007+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:48.007+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:48.007+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / rpm / org.example.stemwatch / end / fail
05-22 01:11:48.007+0900 D/PKGMGR  ( 2277): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[rpm] pkgid[org.example.stemwatch]key[end] val[fail]
05-22 01:11:48.007+0900 D/APPS    ( 2277): pkgmgr.c: _pkgmgr_cb(704) >  pkgmgr request [end:fail] for org.example.stemwatch
05-22 01:11:48.007+0900 E/W_HOME  ( 2277): pkgmgr.c: _end(649) > (strcasecmp(val, "ok")) -> _end() return
05-22 01:11:48.007+0900 E/APPS    ( 2277): pkgmgr.c: _pkgmgr_cb(711) >  pkgmgr_cbs[6].func has errors.
05-22 01:11:48.007+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:48.007+0900 D/PKGMGR  ( 2277): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:48.007+0900 D/PKGMGR  ( 2259): comm_client_gdbus.c: _on_signal_handle_filter(183) > [SECURE_LOG] Got signal: [status] org.example.stemwatch_1993560091 / rpm / org.example.stemwatch / end / fail
05-22 01:11:48.007+0900 D/PKGMGR  ( 2259): pkgmgr.c: __status_callback(440) > [SECURE_LOG] __status_callback() req_id[org.example.stemwatch_1993560091] pkg_type[rpm] pkgid[org.example.stemwatch]key[end] val[fail]
05-22 01:11:48.007+0900 D/PKGMGR  ( 2259): comm_client_gdbus.c: _on_signal_handle_filter(189) > callback function is end
05-22 01:11:48.007+0900 D/PKGMGR  ( 2259): comm_client_gdbus.c: _on_signal_handle_filter(191) > Handled signal. Exit function
05-22 01:11:48.027+0900 W/CRASH_MANAGER( 2582): worker.c: worker_job(1189) > 110258172706d1463847107
05-22 01:11:48.047+0900 W/CRASH_MANAGER( 2582): worker.c: worker_job(1189) > 1102550737465146384710
