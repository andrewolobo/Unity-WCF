using System;
using System.Web.Services;
 
[WebService (Namespace = "http://localhost:9000/MyService")]
public class MyService
{
	[WebMethod]
	public int Add(int a, int b)
	{
		return a+b;
	}
}