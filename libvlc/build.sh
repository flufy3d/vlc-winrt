#! /bin/bash

#if you are using windows docker use internal folder to build

cp /build /root/build -r

cd /root/build

export ARCH=i686
./compile.sh ${ARCH} win10
cp /root/build/vlc/winrt-${ARCH}-ucrt/*.7z /build/

export ARCH=x86_64
./compile.sh ${ARCH} win10
cp /root/build/vlc/winrt-${ARCH}-ucrt/*.7z /build/

export ARCH=aarch64
./compile.sh ${ARCH} win10
cp /root/build/vlc/winrt-${ARCH}-ucrt/*.7z /build/

export ARCH=armv7
./compile.sh ${ARCH} win10
cp /root/build/vlc/winrt-${ARCH}-ucrt/*.7z /build/



echo 'done!'