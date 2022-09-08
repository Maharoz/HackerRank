//https://www.hackerrank.com/challenges/time-conversion/

string s =convert("11:45:20AM");
Console.WriteLine(s);

string convert(string s)
{
    string f = s.Substring(0, 2);
    string t = s.Substring(s.Length - 2);
    string r = string.Empty;
    if (t == "PM" && f!="12")
    {
        int m = Convert.ToInt32(f)+12;
        string n = m.ToString();
        r = n + s.Substring(2);
        return r.Remove(s.Length - 2);
    }
    else if(t=="PM" && f == "12")
    {
        r = s.Remove(s.Length - 2);
        return r;
    }else if(t == "AM" && f == "12")
    {
        r = "00" + s.Substring(2);
        return r.Remove(s.Length - 2);
    }
    else
    {
        return s.Remove(s.Length - 2);
    }
    return r;
}
