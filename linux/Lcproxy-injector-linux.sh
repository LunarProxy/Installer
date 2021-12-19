#!/bin/sh
#! /bin/bash
if pgrep -x java >/dev/null   ; then
cd ~/.lunarclient/jre/zulu*/lib/security
keytool -keystore cacerts -trustcacerts -importcert -noprompt -alias lcproxy -storepass changeit -file ~/LCP/server.cer
clear
echo injected
sleep 1;
clear
exec bash "$0" "$@"
else
clear
echo Waiting for java ... "(run lunar, it may reinstall the JRE but this is NORMAL, just wait until it installs and when it opens everything should be there)"
sleep 1;
exec bash "$0" "$@"
fi



