function himekuri()
  version = _VERSION
  today = os.date("現在時刻 : %Y年%m月%d日 : %H時%M分%S秒")
  new_year = os.date("%j")
  calc_year = os.date("%Y")

  print(today)
  print(string.format("来年の1月1日まであと : %d%s", 365-tonumber(new_year), "日です"))
  print(string.format("令和%d年%s", tonumber(calc_year)-2018, os.date("%m月%d日")), string.format(":  R%d年%s", tonumber(calc_year)-2018, os.date("%m月%d日")))
  print("Lua_VERSION  :",version)
end

--[[

関数、メソッド定義、実行結果

現在時刻 : 2023年03月20日 : 16時06分50秒
来年の1月1日まであと : 079日です
令和5年03月20日  :  R5年03月20日
Lua_VERSION  :  Lua 5.2

]]

himekuri()
