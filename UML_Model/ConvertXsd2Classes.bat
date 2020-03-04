@echo off

xsd Profiles.xsd /c /out:.. /namespace:SendVoiceCommands
xsd PianoKeyToFrequency.xsd /c /out:.. /namespace:SendVoiceCommands
