#!/bin/sh

if [[ $EUID -eq 0 ]]; then
    echo -e ${RED}ERROR "Do not run this as root idiot"
    exit 1
elif [ -d "/home/$USER/.lunarclient" ]; then
echo ______________________
echo Starting Installer ...
echo ______________________
sleep 2;
cd ~/.lunarclient/jre/zulu*/lib/security
mkdir ~/LCP
wget https://cdn.discordapp.com/attachments/921738244473905213/922003853677821963/server.cer && mv server.cer ~/LCP
clear
#test
keytool -keystore cacerts -trustcacerts -importcert -alias lcproxy -noprompt -storepass changeit -file ~/LCP/server.cer
echo server certificate test complete
wget https://raw.githubusercontent.com/LunarProxy/Installer/main/linux/hosts && mv hosts ~/Downloads
wget https://raw.githubusercontent.com/LunarProxy/Installer/main/linux/Lcproxy-injector-linux.sh && mv Lcproxy-injector-linux.sh ~/LCP
mkdir ~/host-backup
sudo cp /etc/hosts ~/host-backup
echo Created hosts backup @ "/home/$USER/host-backup"
sudo cp ~/Downloads/hosts /etc/
clear
rm ~/Downloads/hosts
echo done! Rebooting is recommended
echo You will find the injector in "/home/$USER/LCP"
echo autostarting injector in 5 seconds
sleep 1;
echo autostarting injector in 4 seconds
sleep 1;
echo autostarting injector in 3 seconds
sleep 1;
echo autostarting injector in 2 seconds
sleep 1;
echo autostarting injector in 1 seconds
sleep 1;
clear
echo starting
cd ~/
chmod ugo+rwx ~/LCP/Lcproxy-injector-linux.sh
./LCP/Lcproxy-injector-linux.sh
sleep 5;
#cool song
kill -9 $PPID
else
echo ERROR! please install/reinstall lunar and run it or check your internet connection
fi
