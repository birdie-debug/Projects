# Uninstalling Win32 Products/Applications


Get-WmiObject -Class Win32_Product | Select-Object -Property Name > "~\Desktop\Win32_Products.txt"

# My Clean PC
$mycleanpc = Select-String -Path "~\Desktop\Win32_Products.txt" -Pattern "MyCleanPC"

if ($mycleanpc -ne $null)
{
    $uninstallmycleanpc = Get-WmiObject -Class Win32_Product | Where-Object{$_.Name -eq "MyCleanPC"}
    $uninstallmycleanpc.Uninstall()
}
else
{
    echo MyCleanPC doesnt exist on this computer
}

# End

# Uninstalling PuTTY

$checkputty = Test-Path "C:\Program Files (x86)\PuTTY"
IF ($checkputty = "True") {
# uninstall
Uninstall-Package putty
}
else{

echo Putty does not exist on this computer
}


# End

$chrome = Test-Path "C:\Program Files (x86)\Google\Chrome\Application\chrome.exe"
IF ($chrome = "True") {
# uninstall
(Get-ItemProperty -path 'HKLM:\SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\Google Chrome').version | ForEach-Object {& ${env:ProgramFiles(x86)}\Google\Chrome\Application\$_\Installer\setup.exe --uninstall --multi-install --chrome --system-level --force-uninstall}

}
else{

echo Google Chrome does not exist on this computer
}

# Uninstall CCLEANER
if (Get-ItemProperty -Path HKLM:\Software\Microsoft\Windows\CurrentVersion\Uninstall\* |
    Where-Object DisplayName -eq CCleaner -OutVariable Results) {
    & "$($Results.InstallLocation)\uninst.exe" /S
}


# uninstall npcap C:\"Program Files"\Npcap\Uninstall.exe /S



$npcap = Test-Path "C:\Program Files\Npcap"
IF ($npcap = "True") {
# uninstall
C:\"Program Files"\Npcap\Uninstall.exe /S
}
else{

echo NPCAP does not exist on this computer
}


# uninstalling wireshark

$wireshark = Test-Path "C:\Program Files\Wireshark"
IF ($wireshark = "True") {
# uninstall
C:\"Program Files"\Wireshark\uninstall.exe /S
}
else{

echo Wireshark does not exist on this computer
}





