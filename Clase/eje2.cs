using System;

class Cuenta{

	public static int cuenta(int num){
		if(num==100){
			Console.Writeline(num);
			return 0;
		}
		else{
			Console.Writeline(num);
			cuenta(num+1);
		}
	}

	static void Main(){
		Cuenta.cuenta(0);
		Console.ReadKey(true);
	}
}