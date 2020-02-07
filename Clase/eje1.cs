
class Factorial{

	public static int factorial(int num){
		if(num==0)
			return 1;
		return factorial(num-1)*num;
	}

	static void Main(){
		int num = System.Convert.ToInt32(System.Console.Readline());

		int fac= Factorial.factorial(num);

		System.Console.WriteLine(fac);
	}
}

