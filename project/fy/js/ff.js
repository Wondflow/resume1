var i=0;
	var x1;
	var eid=setInterval("fun2()",1000);
	function fun2()
	{
		i++;
		i=i%4;
		var img=document.getElementById("img1");
		img.src="../ff/" + i + ".jpg";
	}
		function show2(num)
		{
			if(num==1)
			{
				clearInterval(eid);
			}
			if(num==2)
			{
				eid=setInterval("fun1()",1000);
			}
		}