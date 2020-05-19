#! /bin/bash
docker run -it -v ///host_mnt/$(pwd)://build  --name vlc vlc_build_image:3.2.0 bash