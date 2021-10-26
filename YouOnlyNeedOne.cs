public class Kata
{
  public static bool Check(object[] a, object x)
  {
    foreach (var i in a){
      if (i.Equals(x)){
        return true;
      }
    }
    return false;
  }
}