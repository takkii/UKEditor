function himekuri()
  version = _VERSION
  today = os.date("���ݎ��� : %Y�N%m��%d�� : %H��%M��%S�b")
  new_year = os.date("%j")
  calc_year = os.date("%Y")

  print(today)
  print(string.format("���N��1��1���܂ł��� : %d%s", 365-tonumber(new_year), "���ł�"))
  print(string.format("�ߘa%d�N%s", tonumber(calc_year)-2018, os.date("%m��%d��")), string.format(":  R%d�N%s", tonumber(calc_year)-2018, os.date("%m��%d��")))
  print("Lua_VERSION  :",version)
end

--[[

�֐��A���\�b�h��`�A���s����

���ݎ��� : 2023�N03��20�� : 16��06��50�b
���N��1��1���܂ł��� : 079���ł�
�ߘa5�N03��20��  :  R5�N03��20��
Lua_VERSION  :  Lua 5.2

]]

himekuri()
