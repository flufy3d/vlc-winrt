# VLC for Windows 10 Desktop, Mobile and Xbox



## Tips
* docker build -t vlc_build_image:3.2.0 .
* docker run -it -v //host_mnt/$(pwd)://build  --name vlc vlc_build_image:3.2.0 bash
* //delete image
* docker rmi 1b70dfa01a17
* //clear unused resource
* docker system prune
* //git apply patch
* git am -3 /d/Projects/vlc-winrt/libvlc/patches/*.patch
* //git gen patch -n the recent n commit
* git format-patch -1
