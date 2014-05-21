GreedySpeech
============

A Html5 recorder with Ajax and C# Asp.net Mvc3 

首先感谢Matt Diamond的开源项目Recorderjs（详细请见：https://github.com/mattdiamond/Recorderjs）
本项目录音部分引用了该项目

上面提到的项目直接下载下来就可以实现录音了，还可以在线体验录的音，但是无法满足我的需求，我需要将其上传至服务端

参考了一些资料，采用的是websocket,对于我的项目来说过于麻烦，因此我采取了 Ajax和Asp.net mvc3和Matt Diamond的Recorderjs 实现了这个例子


Recorderjs负责录音生成Blob

Ajax将Bolb上传

Mvc3 Controller 负责接收上传的Blob进行处理（目前仅将文件保存为本地.wav）
