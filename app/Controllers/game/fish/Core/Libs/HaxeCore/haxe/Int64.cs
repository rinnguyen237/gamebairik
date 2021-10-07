// Generated by Haxe 3.4.4

#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe._Int64 {
	public sealed class Int64_Impl_ {
		
		public static long make(int high, int low) {
			unchecked {
				long this1 = ((long) (( ((long) (( ((long) (high) ) << 32 )) ) | ((long) (( ((long) (low) ) & ((long) (0xffffffffL) ) )) ) )) );
				return ((long) (this1) );
			}
		}
		
		
		public static long _new(long x) {
			long this1 = x;
			return ((long) (this1) );
		}
		
		
		
		
		public static long get_val(long this1) {
			return this1;
		}
		
		
		public static long set_val(long this1, long x) {
			this1 = x;
			return this1;
		}
		
		
		
		
		public static int get_high(long this1) {
			unchecked {
				return ((int) (((long) (( this1 >> 32 )) )) );
			}
		}
		
		
		
		
		public static int get_low(long this1) {
			return ((int) (this1) );
		}
		
		
		public static long copy(long this1) {
			long this2 = this1;
			return ((long) (this2) );
		}
		
		
		public static long ofInt(int x) {
			return ((long) (x) );
		}
		
		
		public static int toInt(long x) {
			unchecked {
				if (( ((bool) (( ((long) (x) ) < -2147483648 )) ) || ((bool) (( ((long) (x) ) > 2147483647 )) ) )) {
					throw global::haxe.lang.HaxeException.wrap("Overflow");
				}
				
				return ((int) (((long) (x) )) );
			}
		}
		
		
		public static bool @is(object val) {
			return ( val is global::System.Int64 );
		}
		
		
		public static int getHigh(long x) {
			unchecked {
				return ((int) (((long) (( ((long) (x) ) >> 32 )) )) );
			}
		}
		
		
		public static int getLow(long x) {
			return ((int) (((long) (x) )) );
		}
		
		
		public static bool isNeg(long x) {
			return ((bool) (( ((long) (x) ) < 0 )) );
		}
		
		
		public static bool isZero(long x) {
			return ( ((long) (x) ) == 0 );
		}
		
		
		public static int compare(long a, long b) {
			unchecked {
				if (((bool) (( ((long) (a) ) < ((long) (b) ) )) )) {
					return -1;
				}
				
				if (((bool) (( ((long) (a) ) > ((long) (b) ) )) )) {
					return 1;
				}
				
				return 0;
			}
		}
		
		
		public static int ucompare(long a, long b) {
			unchecked {
				if (((bool) (( ((long) (a) ) < 0 )) )) {
					if (((bool) (( ((long) (b) ) < 0 )) )) {
						if (((bool) (( ((long) (a) ) < ((long) (b) ) )) )) {
							return -1;
						}
						else if (((bool) (( ((long) (a) ) > ((long) (b) ) )) )) {
							return 1;
						}
						else {
							return 0;
						}
						
					}
					else {
						return 1;
					}
					
				}
				
				if (((bool) (( ((long) (b) ) < 0 )) )) {
					return -1;
				}
				else if (((bool) (( ((long) (a) ) < ((long) (b) ) )) )) {
					return -1;
				}
				else if (((bool) (( ((long) (a) ) > ((long) (b) ) )) )) {
					return 1;
				}
				else {
					return 0;
				}
				
			}
		}
		
		
		public static string toStr(long x) {
			return global::haxe.lang.Runtime.concat("", global::Std.@string(((long) (x) )));
		}
		
		
		public static object divMod(long dividend, long divisor) {
			return new global::haxe.lang.DynamicObject(new int[]{845179051, 2012934199}, new object[]{((long) (( ((long) (dividend) ) / ((long) (divisor) ) )) ), ((long) (( ((long) (dividend) ) % ((long) (divisor) ) )) )}, new int[]{}, new double[]{});
		}
		
		
		public static string toString(long this1) {
			return global::haxe.lang.Runtime.concat("", global::Std.@string(this1));
		}
		
		
		public static long parseString(string sParam) {
			return global::haxe.Int64Helper.parseString(sParam);
		}
		
		
		public static long fromFloat(double f) {
			return global::haxe.Int64Helper.fromFloat(f);
		}
		
		
		public static long neg(long x) {
			return  - (((long) (x) )) ;
		}
		
		
		public static long preIncrement(long this1) {
			return  ++ this1;
		}
		
		
		public static long postIncrement(long this1) {
			return this1++;
		}
		
		
		public static long preDecrement(long this1) {
			return  -- this1;
		}
		
		
		public static long postDecrement(long this1) {
			return this1--;
		}
		
		
		public static long @add(long a, long b) {
			return ((long) (( ((long) (a) ) + ((long) (b) ) )) );
		}
		
		
		public static long addInt(long a, int b) {
			return ((long) (( ((long) (a) ) + b )) );
		}
		
		
		public static long sub(long a, long b) {
			return ((long) (( ((long) (a) ) - ((long) (b) ) )) );
		}
		
		
		public static long subInt(long a, int b) {
			return ((long) (( ((long) (a) ) - b )) );
		}
		
		
		public static long intSub(int a, long b) {
			return ((long) (( a - ((long) (b) ) )) );
		}
		
		
		public static long mul(long a, long b) {
			return ((long) (( ((long) (a) ) * ((long) (b) ) )) );
		}
		
		
		public static long mulInt(long a, int b) {
			return ((long) (( ((long) (a) ) * b )) );
		}
		
		
		public static long div(long a, long b) {
			return ((long) (( ((long) (a) ) / ((long) (b) ) )) );
		}
		
		
		public static long divInt(long a, int b) {
			return ((long) (( ((long) (a) ) / b )) );
		}
		
		
		public static long intDiv(int a, long b) {
			return ((long) (( a / ((long) (b) ) )) );
		}
		
		
		public static long mod(long a, long b) {
			return ((long) (( ((long) (a) ) % ((long) (b) ) )) );
		}
		
		
		public static long modInt(long a, int b) {
			return ((long) (( ((long) (a) ) % b )) );
		}
		
		
		public static long intMod(int a, long b) {
			return ((long) (( a % ((long) (b) ) )) );
		}
		
		
		public static bool eq(long a, long b) {
			return ( ((long) (a) ) == ((long) (b) ) );
		}
		
		
		public static bool eqInt(long a, int b) {
			return ( ((long) (a) ) == b );
		}
		
		
		public static bool neq(long a, long b) {
			return ( ((long) (a) ) != ((long) (b) ) );
		}
		
		
		public static bool neqInt(long a, int b) {
			return ( ((long) (a) ) != b );
		}
		
		
		public static bool lt(long a, long b) {
			return ((bool) (( ((long) (a) ) < ((long) (b) ) )) );
		}
		
		
		public static bool ltInt(long a, int b) {
			return ((bool) (( ((long) (a) ) < b )) );
		}
		
		
		public static bool intLt(int a, long b) {
			return ((bool) (( a < ((long) (b) ) )) );
		}
		
		
		public static bool lte(long a, long b) {
			return ((bool) (( ((long) (a) ) <= ((long) (b) ) )) );
		}
		
		
		public static bool lteInt(long a, int b) {
			return ((bool) (( ((long) (a) ) <= b )) );
		}
		
		
		public static bool intLte(int a, long b) {
			return ((bool) (( a <= ((long) (b) ) )) );
		}
		
		
		public static bool gt(long a, long b) {
			return ((bool) (( ((long) (a) ) > ((long) (b) ) )) );
		}
		
		
		public static bool gtInt(long a, int b) {
			return ((bool) (( ((long) (a) ) > b )) );
		}
		
		
		public static bool intGt(int a, long b) {
			return ((bool) (( a > ((long) (b) ) )) );
		}
		
		
		public static bool gte(long a, long b) {
			return ((bool) (( ((long) (a) ) >= ((long) (b) ) )) );
		}
		
		
		public static bool gteInt(long a, int b) {
			return ((bool) (( ((long) (a) ) >= b )) );
		}
		
		
		public static bool intGte(int a, long b) {
			return ((bool) (( a >= ((long) (b) ) )) );
		}
		
		
		public static long complement(long x) {
			return  ~ (((long) (x) )) ;
		}
		
		
		public static long and(long a, long b) {
			return ((long) (( ((long) (a) ) & ((long) (b) ) )) );
		}
		
		
		public static long or(long a, long b) {
			return ((long) (( ((long) (a) ) | ((long) (b) ) )) );
		}
		
		
		public static long xor(long a, long b) {
			return ((long) (( ((long) (a) ) ^ ((long) (b) ) )) );
		}
		
		
		public static long shl(long a, int b) {
			return ((long) (( ((long) (a) ) << b )) );
		}
		
		
		public static long shr(long a, int b) {
			return ((long) (( ((long) (a) ) >> b )) );
		}
		
		
		public static long ushr(long a, int b) {
			return ((long) (((ulong) (( ((ulong) (((long) (a) )) ) >> b )) )) );
		}
		
		
	}
}


