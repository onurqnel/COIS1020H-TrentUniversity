public class Clock
{
private int hours;
private int minutes;
private char clockPeriod;
 // No Parameter Constructor
 public Clock()
 {
 // insert code here
 }
 // Three Parameter Constructor
 public Clock(int hrs, int mins, char cType)
 {
 // insert code here
 }
 // Hours Property
 public int Hours
 {
 // insert code here
 }
// Minutes Property
 public int Minutes
 {
 // insert code here
 }
 public char ClockPeriod
 {
 // insert code here
 }
// ToString method
 public override string ToString()
 {
 // insert code here
 }
 // Overloaded Operator Addition method
 public static Clock operator+(Clock clk1, Clock clk2)
 {
 // insert code here
}
// Greater Than operator
 public static bool operator>(Clock clk1, Clock clk2)
 {
 // insert code here
 }
// Less Than operator
public static bool operator<(Clock clk1, Clock clk2)
 {
 // insert code here
 }
}