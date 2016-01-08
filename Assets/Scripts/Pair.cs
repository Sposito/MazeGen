using System.Collections;

public class Pair  {
	public int x, y;

	public Pair(int x, int y){
		this.x = x;
		this.y = y;
	}

	public static Pair operator + (Pair p1, Pair p2){
		return new Pair (p1.x + p2.x, p1.y + p2.y);
	}


}
