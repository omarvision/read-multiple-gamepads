
using UnityEngine;
using UnityEngine.UI; //for UI Text gameobjects
using System.Text; //for StringBuilder

public class GamepadReader : MonoBehaviour
{
    public Text txtGamepads = null;
    public Text txtGamepadAll = null;
    public Text txtGamepad1 = null;
    public Text txtGamepad2 = null;

    public void Update()
    {
        // what gamepads(joysticks) are connected?
        txtGamepads.text = "Input.GetJoystickNames() = ";
        string[] names = Input.GetJoystickNames();
        for (int i = 0; i < names.Length; i++)
        {
            if (i > 0)
                txtGamepads.text += ", " + names[i];
            else
                txtGamepads.text += names[i];
        }

        // [input setting 01-18] are defaults that Unity put there
        // ...

        // Note: 
        //  Each gamepad (like XBox360 controller, Playstation Controller) 
        //  will have 17 inputs that can be read from.
        //      - 7 axis        = analog values [-1.0 - 0.0 - 1.0]
        //      - 10 buttons    = true / false

        // gamepad all
        StringBuilder sbAll = new StringBuilder();
        sbAll.AppendLine("Gamepad all");
        sbAll.AppendLine("[X axis] 'LAnalogX all' = " + Input.GetAxis("LAnalogX all").ToString());
        sbAll.AppendLine("[Y axis] 'LAnalogY all' = " + Input.GetAxis("LAnalogY all").ToString());
        sbAll.AppendLine("[3rd axis (Joysticks and Scrollwheel)] 'Triggers all' = " + Input.GetAxis("Triggers all").ToString());
        sbAll.AppendLine("[4th axis (Joysticks)] 'RAnalogX all' = " + Input.GetAxis("RAnalogX all").ToString());
        sbAll.AppendLine("[5th axis (Joysticks)] 'RAnalogY all' = " + Input.GetAxis("RAnalogY all").ToString());
        sbAll.AppendLine("[6th axis (Joysticks)] 'DpadX all' = " + Input.GetAxis("DpadX all").ToString());
        sbAll.AppendLine("[7th axis (Joysticks)] 'DpadY all' = " + Input.GetAxis("DpadY all").ToString());
        sbAll.AppendLine("[joystick button 0] 'A all' = " + Input.GetButton("A all"));
        sbAll.AppendLine("[joystick button 1] 'B all' = " + Input.GetButton("B all"));
        sbAll.AppendLine("[joystick button 2] 'X all' = " + Input.GetButton("X all"));
        sbAll.AppendLine("[joystick button 3] 'Y all' = " + Input.GetButton("Y all"));
        sbAll.AppendLine("[joystick button 4] 'LB all' = " + Input.GetButton("LB all"));
        sbAll.AppendLine("[joystick button 5] 'RB all' = " + Input.GetButton("RB all"));
        sbAll.AppendLine("[joystick button 6] 'Back all' = " + Input.GetButton("Back all"));
        sbAll.AppendLine("[joystick button 7] 'Start all' = " + Input.GetButton("Start all"));
        sbAll.AppendLine("[joystick button 8] 'LAnalogPress all' = " + Input.GetButton("LAnalogPress all"));
        sbAll.AppendLine("[joystick button 9] 'RAnalogPress all' = " + Input.GetButton("RAnalogPress all"));
        txtGamepadAll.text = sbAll.ToString();

        // gamepad 1
        StringBuilder sb1 = new StringBuilder();
        sb1.AppendLine("Gamepad 1");
        sb1.AppendLine("'LAnalogX 1' = " + Input.GetAxis("LAnalogX 1").ToString());
        sb1.AppendLine("'LAnalogY 1' = " + Input.GetAxis("LAnalogY 1").ToString());
        sb1.AppendLine("'Triggers 1' = " + Input.GetAxis("Triggers 1").ToString());
        sb1.AppendLine("'RAnalogX 1' = " + Input.GetAxis("RAnalogX 1").ToString());
        sb1.AppendLine("'RAnalogY 1' = " + Input.GetAxis("RAnalogY 1").ToString());
        sb1.AppendLine("'DpadX 1' = " + Input.GetAxis("DpadX 1").ToString());
        sb1.AppendLine("'DpadY 1' = " + Input.GetAxis("DpadY 1").ToString());
        sb1.AppendLine("'A 1' = " + Input.GetButton("A 1"));
        sb1.AppendLine("'B 1' = " + Input.GetButton("B 1"));
        sb1.AppendLine("'X 1' = " + Input.GetButton("X 1"));
        sb1.AppendLine("'Y 1' = " + Input.GetButton("Y 1"));
        sb1.AppendLine("'LB 1' = " + Input.GetButton("LB 1"));
        sb1.AppendLine("'RB 1' = " + Input.GetButton("RB 1"));
        sb1.AppendLine("'Back 1' = " + Input.GetButton("Back 1"));
        sb1.AppendLine("'Start 1' = " + Input.GetButton("Start 1"));
        sb1.AppendLine("'LAnalogPress 1' = " + Input.GetButton("LAnalogPress 1"));
        sb1.AppendLine("'RAnalogPress 1' = " + Input.GetButton("RAnalogPress 1"));
        txtGamepad1.text = sb1.ToString();

        // gamepad 2
        StringBuilder sb2 = new StringBuilder();
        sb2.AppendLine("Gamepad 2");
        sb2.AppendLine("'LAnalogX 2' = " + Input.GetAxis("LAnalogX 2").ToString());
        sb2.AppendLine("'LAnalogY 2' = " + Input.GetAxis("LAnalogY 2").ToString());
        sb2.AppendLine("'Triggers 2' = " + Input.GetAxis("Triggers 2").ToString());
        sb2.AppendLine("'RAnalogX 2' = " + Input.GetAxis("RAnalogX 2").ToString());
        sb2.AppendLine("'RAnalogY 2' = " + Input.GetAxis("RAnalogY 2").ToString());
        sb2.AppendLine("'DpadX 2' = " + Input.GetAxis("DpadX 2").ToString());
        sb2.AppendLine("'DpadY 2' = " + Input.GetAxis("DpadY 2").ToString());
        sb2.AppendLine("'A 2' = " + Input.GetButton("A 2"));
        sb2.AppendLine("'B 2' = " + Input.GetButton("B 2"));
        sb2.AppendLine("'X 2' = " + Input.GetButton("X 2"));
        sb2.AppendLine("'Y 2' = " + Input.GetButton("Y 2"));
        sb2.AppendLine("'LB 2' = " + Input.GetButton("LB 2"));
        sb2.AppendLine("'RB 2' = " + Input.GetButton("RB 2"));
        sb2.AppendLine("'Back 2' = " + Input.GetButton("Back 2"));
        sb2.AppendLine("'Start 2' = " + Input.GetButton("Start 2"));
        sb2.AppendLine("'LAnalogPress 2' = " + Input.GetButton("LAnalogPress 2"));
        sb2.AppendLine("'RAnalogPress 2' = " + Input.GetButton("RAnalogPress 2"));
        txtGamepad2.text = sb2.ToString();
    }
}
