## AvaloniaOpacityTests (11-Preview VS 0.10.18)

Using Avalonia 11-preview, assigning **PointerEntered** event, making Opacity=0.8, and **PointerExited** event, making Opacity=0.0, to a control (e.g. a panel), <u>once the opacity is set to 0.0 in PointerExited, the control doesn't answer to PointerEntered anymore</u>.



**AvaOpacityTest11Preview** is a cross platform solution using Avalonia 11-preview. Compiling the Desktop project you'll see the bug described above.

**AvaOpacityTest01018** is the same project in a solution using the latest stable version of Avalonia (0.10.18). Here the events and the opacity work fine as expected.
