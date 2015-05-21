using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Text.RegularExpressions;


public class SortMachine
{
	public int countMoves(int[] a)
	{
        int moves = 0;
        List<int> arrayList = new List<int>();
        for (int i = 0; i < a.Length; i++)
        {
            arrayList.Add(a[i]);
        }

        for (int i = 0; i < arrayList.Count; i++)
        {
            if (i != arrayList.Count -1 && arrayList[i] > arrayList[i+1])
            {
                arrayList.Add(arrayList[i]);
                moves++;
                //continue;
            }
        }

        return moves;
		
	}

	// BEGIN KAWIGIEDIT TESTING
	// Generated by KawigiEdit 2.1.4 (beta) modified by pivanof
	#region Testing code generated by KawigiEdit
	[STAThread]
	private static Boolean KawigiEdit_RunTest(int testNum, int[] p0, Boolean hasAnswer, int p1) {
		Console.Write("Test " + testNum + ": [" + "{");
		for (int i = 0; p0.Length > i; ++i) {
			if (i > 0) {
				Console.Write(",");
			}
			Console.Write(p0[i]);
		}
		Console.Write("}");
		Console.WriteLine("]");
		SortMachine obj;
		int answer;
		obj = new SortMachine();
		DateTime startTime = DateTime.Now;
		answer = obj.countMoves(p0);
		DateTime endTime = DateTime.Now;
		Boolean res;
		res = true;
		Console.WriteLine("Time: " + (endTime - startTime).TotalSeconds + " seconds");
		if (hasAnswer) {
			Console.WriteLine("Desired answer:");
			Console.WriteLine("\t" + p1);
		}
		Console.WriteLine("Your answer:");
		Console.WriteLine("\t" + answer);
		if (hasAnswer) {
			res = answer == p1;
		}
		if (!res) {
			Console.WriteLine("DOESN'T MATCH!!!!");
		} else if ((endTime - startTime).TotalSeconds >= 2) {
			Console.WriteLine("FAIL the timeout");
			res = false;
		} else if (hasAnswer) {
			Console.WriteLine("Match :-)");
		} else {
			Console.WriteLine("OK, but is it right?");
		}
		Console.WriteLine("");
		return res;
	}
	public static void Main(string[] args) {
		Boolean all_right;
		all_right = true;
		
		int[] p0;
		int p1;
		
		// ----- test 0 -----
		p0 = new int[]{19,7,8,25};
		p1 = 2;
		all_right = KawigiEdit_RunTest(0, p0, true, p1) && all_right;
		// ------------------
		
		// ----- test 1 -----
		p0 = new int[]{1,2,3,4,5};
		p1 = 0;
		all_right = KawigiEdit_RunTest(1, p0, true, p1) && all_right;
		// ------------------
		
		// ----- test 2 -----
		p0 = new int[]{1000,-1000,0};
		p1 = 1;
		all_right = KawigiEdit_RunTest(2, p0, true, p1) && all_right;
		// ------------------
		
		// ----- test 3 -----
		p0 = new int[]{1,3,4,5,6,7,8,9,2};
		p1 = 7;
		all_right = KawigiEdit_RunTest(3, p0, true, p1) && all_right;
		// ------------------
		
		// ----- test 4 -----
		p0 = new int[]{-2,-8,9,0};
		p1 = 3;
		all_right = KawigiEdit_RunTest(4, p0, true, p1) && all_right;
		// ------------------
		
		// ----- test 5 -----
		p0 = new int[]{976,-946,-824,680,-644,-95,128,-892,816,-263,-592,-669,887,447,-653,-759,572,171,635,98,-904,78,143,-416,-40,-846,784,-702,-738,-858,582,603,-535,529,84,-964,934,36,783};
		p1 = 38;
		all_right = KawigiEdit_RunTest(5, p0, true, p1) && all_right;
		// ------------------
		
		if (all_right) {
			Console.WriteLine("You're a stud (at least on the example cases)!");
		} else {
			Console.WriteLine("Some of the test cases had errors.");
		}

        Console.ReadLine();
	}
	#endregion
	// END KAWIGIEDIT TESTING
}
//Powered by KawigiEdit 2.1.4 (beta) modified by pivanof!
