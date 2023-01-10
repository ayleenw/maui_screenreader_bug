# .NET MAUI Accessibility - problems with screenreader on Android 12

## TalkBack on Android 12 will not (correctly) recognise headings declared with *SemanticProperties.HeadingLevel*

**This can even be tested with the boilerplate Hello World MAUI App:**  
1. Deploy to Android 12 device  
2. Switch on TalkBack  
3. 3-finger swipe until screen reader is set to "Headings"  
4. Swipe down with one finger to go to next heading  
-> TalkBack will say "No next heading", although in the Hello World App there are 2 headings defined  

It seems, that TalkBack recognises content in a VerticalStackLayout as a block (see green box drawn around the VerticalStackLayout content in following image), reading this out as a complete block and not detect the headings inside.

This happens on a OnePlus 7 (GM1903) with stock Android 12, Build number GM1903_11_H.30, Kernel version 4.14.180-perf+


![Screen reader output of MAUI Hello World App on Android 12](https://raw.githubusercontent.com/ayleenw/maui_screenreader_bug/main/maui_hw_talkback.jpg "Screen reader output of MAUI Hello World App on Android 12")