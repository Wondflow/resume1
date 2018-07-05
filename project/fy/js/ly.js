var i=0;
	var x1;
	var tid=setInterval("fun1()",1000);
	function fun1()
	{
		i++;
		i=i % 3;
		var img2=document.getElementById("img3");
		img2.src="../ly/" + i + ".jpg";
	}
		function show1(num)
		{
			if(num==1)
			{
				clearInterval(tid);
			}
			if(num==2)
			{
				tid=setInterval("fun1()",1000);
			}
		}