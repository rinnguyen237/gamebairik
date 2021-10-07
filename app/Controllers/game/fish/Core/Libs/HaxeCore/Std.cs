// Generated by Haxe 3.4.4

#pragma warning disable 109, 114, 219, 429, 168, 162
public class Std {
	
	public Std() {
	}
	
	
	public static bool @is(object v, object t) {
		if (( v == null )) {
			return global::haxe.lang.Runtime.eq(t, typeof(object));
		}
		
		if (( t == null )) {
			return false;
		}
		
		global::System.Type clt = ((global::System.Type) (( t as global::System.Type )) );
		if (global::haxe.lang.Runtime.typeEq(clt, null)) {
			return false;
		}
		
		{
			string _g = ( clt as global::System.Reflection.MemberInfo ).ToString();
			switch (_g) {
				case "System.Boolean":
				{
					return v is bool;
				}
				
				
				case "System.Double":
				{
					return v is double || v is int;
				}
				
				
				case "System.Int32":
				{
					return global::haxe.lang.Runtime.isInt(v);
				}
				
				
				case "System.Object":
				{
					return true;
				}
				
				
			}
			
		}
		
		global::System.Type vt = v.GetType();
		if (clt.IsAssignableFrom(((global::System.Type) (vt) ))) {
			return true;
		}
		
		{
			uint _g1_idx = default(uint);
			global::System.Type[] _g1_arr = clt.GetInterfaces();
			_g1_idx = ((uint) (0) );
			while (((bool) (( _g1_idx < ( _g1_arr as global::System.Array ).Length )) )) {
				global::System.Type iface = ((global::System.Type) (_g1_arr[((int) (_g1_idx++) )]) );
				global::haxe.lang.GenericInterface g = global::haxe.lang.Runtime.getGenericAttr(iface);
				if (( ( g != null ) && global::haxe.lang.Runtime.typeEq(g.generic, clt) )) {
					return iface.IsAssignableFrom(((global::System.Type) (vt) ));
				}
				
			}
			
		}
		
		return false;
	}
	
	
	public static string @string(object s) {
		if (( s == null )) {
			return "null";
		}
		
		if (( s is bool )) {
			if (global::haxe.lang.Runtime.toBool(s)) {
				return "true";
			}
			else {
				return "false";
			}
			
		}
		
		return s.ToString();
	}
	
	
	public static int @int(double x) {
		return ((int) (x) );
	}
	
	
	public static global::haxe.lang.Null<int> parseInt(string x) {
		unchecked {
			if (string.Equals(x, null)) {
				return default(global::haxe.lang.Null<int>);
			}
			
			int ret = 0;
			int @base = 10;
			int i = -1;
			int len = x.Length;
			if (( x.StartsWith("0") && ( len > 2 ) )) {
				int c = ((int) (global::haxe.lang.Runtime.toInt(x[1])) );
				if (( ( c == 120 ) || ( c == 88 ) )) {
					i = 1;
					@base = 16;
				}
				
			}
			
			bool foundAny = ( i != -1 );
			bool isNeg = false;
			while ((  ++ i < len )) {
				int c1 = ((int) (global::haxe.lang.Runtime.toInt(x[i])) );
				if ( ! (foundAny) ) {
					switch (c1) {
						case 9:
						case 10:
						case 13:
						case 32:
						case 43:
						{
							if (isNeg) {
								return default(global::haxe.lang.Null<int>);
							}
							
							continue;
						}
						
						
						case 45:
						{
							isNeg = true;
							continue;
						}
						
						
					}
					
				}
				
				if (( ( c1 >= 48 ) && ( c1 <= 57 ) )) {
					if ((  ! (foundAny)  && ( c1 == 48 ) )) {
						foundAny = true;
						continue;
					}
					
					ret *= @base;
					foundAny = true;
					ret += ( c1 - 48 );
				}
				else if (( @base == 16 )) {
					if (( ( c1 >= 97 ) && ( c1 <= 102 ) )) {
						ret *= @base;
						foundAny = true;
						ret += ( ( c1 - 97 ) + 10 );
					}
					else if (( ( c1 >= 65 ) && ( c1 <= 70 ) )) {
						ret *= @base;
						foundAny = true;
						ret += ( ( c1 - 65 ) + 10 );
					}
					else {
						break;
					}
					
				}
				else {
					break;
				}
				
			}
			
			if (foundAny) {
				if (isNeg) {
					return new global::haxe.lang.Null<int>( - (ret) , true);
				}
				else {
					return new global::haxe.lang.Null<int>(ret, true);
				}
				
			}
			else {
				return default(global::haxe.lang.Null<int>);
			}
			
		}
	}
	
	
	public static double parseFloat(string x) {
		unchecked {
			if (string.Equals(x, null)) {
				return global::MathHaxe.NaN;
			}
			
			x = x.TrimStart();
			bool found = false;
			bool hasDot = false;
			bool hasSign = false;
			bool hasE = false;
			bool hasESign = false;
			bool hasEData = false;
			int i = -1;
			while ((  ++ i < x.Length )) {
				int chr = ((int) (((global::System.String) (x) )[i]) );
				if (( ( chr >= 48 ) && ( chr <= 57 ) )) {
					if (hasE) {
						hasEData = true;
					}
					
					found = true;
				}
				else {
					switch (chr) {
						case 43:
						case 45:
						{
							if ((  ! (found)  &&  ! (hasSign)  )) {
								hasSign = true;
							}
							else if (( ( ( found &&  ! (hasESign)  ) && hasE ) &&  ! (hasEData)  )) {
								hasESign = true;
							}
							else {
								goto label1;
							}
							
							break;
						}
						
						
						case 46:
						{
							if ( ! (hasDot) ) {
								hasDot = true;
							}
							else {
								goto label1;
							}
							
							break;
						}
						
						
						case 69:
						case 101:
						{
							if ( ! (hasE) ) {
								hasE = true;
							}
							else {
								goto label1;
							}
							
							break;
						}
						
						
						default:
						{
							goto label1;
						}
						
					}
					
				}
				
			}
			
			label1: {};
			if (( hasE &&  ! (hasEData)  )) {
				 -- i;
				if (hasESign) {
					 -- i;
				}
				
			}
			
			if (( i != x.Length )) {
				x = global::haxe.lang.StringExt.substr(x, 0, new global::haxe.lang.Null<int>(i, true));
			}
			
			try {
				return global::System.Double.Parse(((string) (x) ), ((global::System.IFormatProvider) (global::System.Globalization.CultureInfo.InvariantCulture) ));
			}
			catch (global::System.Exception __temp_catchallException1){
				global::haxe.lang.Exceptions.exception = __temp_catchallException1;
				object __temp_catchall2 = __temp_catchallException1;
				if (( __temp_catchall2 is global::haxe.lang.HaxeException )) {
					__temp_catchall2 = ((global::haxe.lang.HaxeException) (__temp_catchallException1) ).obj;
				}
				
				{
					object e = __temp_catchall2;
					return global::MathHaxe.NaN;
				}
				
			}
			
			
		}
	}
	
	
	public static int random(int x) {
		if (( x <= 0 )) {
			return 0;
		}
		
		return global::MathHaxe.rand.Next(((int) (x) ));
	}
	
	
}


