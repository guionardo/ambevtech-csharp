#!/bin/env bash
# Docker setup script for WSL2/Ubuntu
# Author: Guionardo Furlan guionardo.furlan@ambevtech.com.br
# Date: 2022-11-17


echo "Setup docker @ WSL2/Ubuntu"

if [ "$EUID" -ne 0 ]
  then 
    echo "Please run this script as root (use sudo $0)"
    exit 1
fi

echo "Called by $SUDO_USER"

function run {    
    local lbl=$1        
    local cmd=$2
    local tmp
    if [ "$3" == "" ]; then
        tmp=$($2)
    else 
        if [ "$4" == "" ]; then
            tmp=$($2 | $3)
        else             
            tmp=$($2 | $3 | $4)
        fi
    fi
    
    if [ $? -eq 0 ]; then
        echo "✔️ $lbl"        
    else
        echo "🛑 $lbl : $1"    
        echo $tmp        
        exit 1
    fi    
}
echo "Updating packages"
run "apt update" "apt-get update" 
run "apt upgrade" "apt-get upgrade -y" 
run "Removing old docker" "apt-get remove docker docker-engine docker.io containerd runc -y"
run "Installing setup tools" "apt-get install apt-transport-https ca-certificates curl gnupg lsb-release -y" 
run "Setup keyring" "curl -fsSL https://download.docker.com/linux/ubuntu/gpg" "gpg --batch --yes --dearmor -o /usr/share/keyrings/docker-archive-keyring.gpg" 
run "Add docker source" 'echo "deb [arch=amd64 signed-by=/usr/share/keyrings/docker-archive-keyring.gpg] https://download.docker.com/linux/ubuntu $(lsb_release -cs) stable" | tee /etc/apt/sources.list.d/docker.list > /dev/null' 
run "Refresh apt" "apt-get update" 
run "Install docker" "apt-get install docker-ce docker-ce-cli containerd.io docker-compose-plugin" 
run "Adding user $SUDO_USER to docker group" "usermod -aG docker $SUDO_USER"

brc=$(grep -c "service docker status ||" /home/$SUDO_USER/.bashrc)
if [ "$brc" == "0" ]; then
    echo "# Docker service status"
    echo 'service docker status || echo "! sudo service docker start"' >> /home/$SUDO_USER/.bashrc
    echo "✔️ .bashrc setup OK"
else
    echo ".bashrc setup already done"
fi
echo "Success!"
echo ""
echo "Run the commands above:"
echo 'service docker start'
