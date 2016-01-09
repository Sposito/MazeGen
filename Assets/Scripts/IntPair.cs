using System.Collections;
using System;

public class Pair  {
	public int x, y;

	public readonly static Pair up    = new Pair( 0, 1);
	public readonly static Pair right = new Pair( 1, 0);
	public readonly static Pair down  = new Pair( 0,-1);
	public readonly static Pair left  = new Pair(-1, 0);
	public readonly static Pair zero  = new Pair( 0, 0);
	public readonly static Pair one   = new Pair( 1, 1);


	public Pair(int x, int y){
		this.x = x;
		this.y = y;
	}

	public static Pair operator + (Pair p1, Pair p2){
		return new Pair (p1.x + p2.x, p1.y + p2.y);
	}

	public static Pair operator * (Pair p1, int m){
		return new Pair (p1.x * m, p1.y * m);
	}

	public static Pair operator * (int m ,Pair p1){
		return new Pair (p1.x * m, p1.y * m);
	}

	public override string ToString(){
		return(String.Format("({0}, {1})", x, y));
	}



}
