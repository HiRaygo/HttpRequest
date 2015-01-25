public bool testhttp()
{
  HttpHeader header = new HttpHeader();
  header.accept = "image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, */*";
  header.contentType = "application/x-www-form-urlencoded";
  header.method = "POST";
  header.userAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
  header.maxTry = 300;
  string html = HTMLHelper.GetHtml("http://guide.renren.com/guide", HTMLHelper.GetCooKie("http://www.renren.com/PLogin.do",
                    "email=aaa@163.com&password=111&icode=&origURL=http%3A%2F%2Fwww.renren.com%2Fhome&domain=renren.com&key_id=1&_rtk=90484476", header), header);

  Console.WriteLine(html);
  Console.ReadLine();
}
