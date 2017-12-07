﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_ContainerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.Container), typeof(FairyGUI.DisplayObject));
		L.RegFunction("AddChild", AddChild);
		L.RegFunction("AddChildAt", AddChildAt);
		L.RegFunction("Contains", Contains);
		L.RegFunction("GetChildAt", GetChildAt);
		L.RegFunction("GetChild", GetChild);
		L.RegFunction("GetChildIndex", GetChildIndex);
		L.RegFunction("RemoveChild", RemoveChild);
		L.RegFunction("RemoveChildAt", RemoveChildAt);
		L.RegFunction("RemoveChildren", RemoveChildren);
		L.RegFunction("SetChildIndex", SetChildIndex);
		L.RegFunction("SwapChildren", SwapChildren);
		L.RegFunction("SwapChildrenAt", SwapChildrenAt);
		L.RegFunction("ChangeChildrenOrder", ChangeChildrenOrder);
		L.RegFunction("GetBounds", GetBounds);
		L.RegFunction("GetRenderCamera", GetRenderCamera);
		L.RegFunction("HitTest", HitTest);
		L.RegFunction("GetHitTestLocalPoint", GetHitTestLocalPoint);
		L.RegFunction("IsAncestorOf", IsAncestorOf);
		L.RegFunction("InvalidateBatchingState", InvalidateBatchingState);
		L.RegFunction("SetChildrenLayer", SetChildrenLayer);
		L.RegFunction("Update", Update);
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("New", _CreateFairyGUI_Container);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("renderMode", get_renderMode, set_renderMode);
		L.RegVar("renderCamera", get_renderCamera, set_renderCamera);
		L.RegVar("opaque", get_opaque, set_opaque);
		L.RegVar("clipSoftness", get_clipSoftness, set_clipSoftness);
		L.RegVar("hitArea", get_hitArea, set_hitArea);
		L.RegVar("touchChildren", get_touchChildren, set_touchChildren);
		L.RegVar("onUpdate", get_onUpdate, set_onUpdate);
		L.RegVar("reversedMask", get_reversedMask, set_reversedMask);
		L.RegVar("numChildren", get_numChildren, null);
		L.RegVar("clipRect", get_clipRect, set_clipRect);
		L.RegVar("mask", get_mask, set_mask);
		L.RegVar("touchable", get_touchable, set_touchable);
		L.RegVar("contentRect", get_contentRect, set_contentRect);
		L.RegVar("fairyBatching", get_fairyBatching, set_fairyBatching);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_Container(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.Container obj = new FairyGUI.Container();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<UnityEngine.GameObject>(L, 1))
			{
				UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.ToObject(L, 1);
				FairyGUI.Container obj = new FairyGUI.Container(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<string>(L, 1))
			{
				string arg0 = ToLua.ToString(L, 1);
				FairyGUI.Container obj = new FairyGUI.Container(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.Container.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddChild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			FairyGUI.DisplayObject arg0 = (FairyGUI.DisplayObject)ToLua.CheckObject<FairyGUI.DisplayObject>(L, 2);
			FairyGUI.DisplayObject o = obj.AddChild(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddChildAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			FairyGUI.DisplayObject arg0 = (FairyGUI.DisplayObject)ToLua.CheckObject<FairyGUI.DisplayObject>(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			FairyGUI.DisplayObject o = obj.AddChildAt(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Contains(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			FairyGUI.DisplayObject arg0 = (FairyGUI.DisplayObject)ToLua.CheckObject<FairyGUI.DisplayObject>(L, 2);
			bool o = obj.Contains(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChildAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			FairyGUI.DisplayObject o = obj.GetChildAt(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			FairyGUI.DisplayObject o = obj.GetChild(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetChildIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			FairyGUI.DisplayObject arg0 = (FairyGUI.DisplayObject)ToLua.CheckObject<FairyGUI.DisplayObject>(L, 2);
			int o = obj.GetChildIndex(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveChild(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
				FairyGUI.DisplayObject arg0 = (FairyGUI.DisplayObject)ToLua.CheckObject<FairyGUI.DisplayObject>(L, 2);
				FairyGUI.DisplayObject o = obj.RemoveChild(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
				FairyGUI.DisplayObject arg0 = (FairyGUI.DisplayObject)ToLua.CheckObject<FairyGUI.DisplayObject>(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				FairyGUI.DisplayObject o = obj.RemoveChild(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.Container.RemoveChild");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveChildAt(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				FairyGUI.DisplayObject o = obj.RemoveChildAt(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				FairyGUI.DisplayObject o = obj.RemoveChildAt(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.Container.RemoveChildAt");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveChildren(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
				obj.RemoveChildren();
				return 0;
			}
			else if (count == 4)
			{
				FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				obj.RemoveChildren(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.Container.RemoveChildren");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetChildIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			FairyGUI.DisplayObject arg0 = (FairyGUI.DisplayObject)ToLua.CheckObject<FairyGUI.DisplayObject>(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.SetChildIndex(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SwapChildren(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			FairyGUI.DisplayObject arg0 = (FairyGUI.DisplayObject)ToLua.CheckObject<FairyGUI.DisplayObject>(L, 2);
			FairyGUI.DisplayObject arg1 = (FairyGUI.DisplayObject)ToLua.CheckObject<FairyGUI.DisplayObject>(L, 3);
			obj.SwapChildren(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SwapChildrenAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.SwapChildrenAt(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ChangeChildrenOrder(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			System.Collections.Generic.List<int> arg0 = (System.Collections.Generic.List<int>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<int>));
			System.Collections.Generic.List<FairyGUI.DisplayObject> arg1 = (System.Collections.Generic.List<FairyGUI.DisplayObject>)ToLua.CheckObject(L, 3, typeof(System.Collections.Generic.List<FairyGUI.DisplayObject>));
			obj.ChangeChildrenOrder(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBounds(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			FairyGUI.DisplayObject arg0 = (FairyGUI.DisplayObject)ToLua.CheckObject<FairyGUI.DisplayObject>(L, 2);
			UnityEngine.Rect o = obj.GetBounds(arg0);
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRenderCamera(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			UnityEngine.Camera o = obj.GetRenderCamera();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HitTest(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
			FairyGUI.DisplayObject o = obj.HitTest(arg0, arg1);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetHitTestLocalPoint(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			UnityEngine.Vector2 o = obj.GetHitTestLocalPoint();
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsAncestorOf(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			FairyGUI.DisplayObject arg0 = (FairyGUI.DisplayObject)ToLua.CheckObject<FairyGUI.DisplayObject>(L, 2);
			bool o = obj.IsAncestorOf(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InvalidateBatchingState(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
				obj.InvalidateBatchingState();
				return 0;
			}
			else if (count == 2)
			{
				FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.InvalidateBatchingState(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.Container.InvalidateBatchingState");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetChildrenLayer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.SetChildrenLayer(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Update(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			FairyGUI.UpdateContext arg0 = (FairyGUI.UpdateContext)ToLua.CheckObject<FairyGUI.UpdateContext>(L, 2);
			obj.Update(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)ToLua.CheckObject<FairyGUI.Container>(L, 1);
			obj.Dispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			UnityEngine.RenderMode ret = obj.renderMode;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_renderCamera(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			UnityEngine.Camera ret = obj.renderCamera;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderCamera on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_opaque(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			bool ret = obj.opaque;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index opaque on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clipSoftness(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			System.Nullable<UnityEngine.Vector4> ret = obj.clipSoftness;
			ToLua.PusNullable(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index clipSoftness on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_hitArea(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			FairyGUI.IHitTest ret = obj.hitArea;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index hitArea on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_touchChildren(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			bool ret = obj.touchChildren;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index touchChildren on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onUpdate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			FairyGUI.EventCallback0 ret = obj.onUpdate;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onUpdate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_reversedMask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			bool ret = obj.reversedMask;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index reversedMask on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_numChildren(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			int ret = obj.numChildren;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index numChildren on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_clipRect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			System.Nullable<UnityEngine.Rect> ret = obj.clipRect;
			ToLua.PusNullable(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index clipRect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			FairyGUI.DisplayObject ret = obj.mask;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mask on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_touchable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			bool ret = obj.touchable;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index touchable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_contentRect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			UnityEngine.Rect ret = obj.contentRect;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index contentRect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_fairyBatching(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			bool ret = obj.fairyBatching;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fairyBatching on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_renderMode(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			UnityEngine.RenderMode arg0 = (UnityEngine.RenderMode)ToLua.CheckObject(L, 2, typeof(UnityEngine.RenderMode));
			obj.renderMode = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderMode on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_renderCamera(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			UnityEngine.Camera arg0 = (UnityEngine.Camera)ToLua.CheckObject(L, 2, typeof(UnityEngine.Camera));
			obj.renderCamera = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index renderCamera on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_opaque(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.opaque = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index opaque on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_clipSoftness(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			System.Nullable<UnityEngine.Vector4> arg0 = ToLua.CheckNullable<UnityEngine.Vector4>(L, 2);
			obj.clipSoftness = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index clipSoftness on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_hitArea(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			FairyGUI.IHitTest arg0 = (FairyGUI.IHitTest)ToLua.CheckObject<FairyGUI.IHitTest>(L, 2);
			obj.hitArea = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index hitArea on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_touchChildren(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.touchChildren = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index touchChildren on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onUpdate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			FairyGUI.EventCallback0 arg0 = (FairyGUI.EventCallback0)ToLua.CheckDelegate<FairyGUI.EventCallback0>(L, 2);
			obj.onUpdate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onUpdate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_reversedMask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.reversedMask = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index reversedMask on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_clipRect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			System.Nullable<UnityEngine.Rect> arg0 = ToLua.CheckNullable<UnityEngine.Rect>(L, 2);
			obj.clipRect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index clipRect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mask(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			FairyGUI.DisplayObject arg0 = (FairyGUI.DisplayObject)ToLua.CheckObject<FairyGUI.DisplayObject>(L, 2);
			obj.mask = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mask on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_touchable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.touchable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index touchable on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_contentRect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			UnityEngine.Rect arg0 = StackTraits<UnityEngine.Rect>.Check(L, 2);
			obj.contentRect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index contentRect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_fairyBatching(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Container obj = (FairyGUI.Container)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.fairyBatching = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index fairyBatching on a nil value");
		}
	}
}

