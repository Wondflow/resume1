var i=0;
	var x1;
	var eid=setInterval("fu2()",1000);
	function fu2()
	{
		i++;
		i=i%3;
		var img=document.getElementById("im1");
		img.src="../photo1/" + i + ".jpg";
	}
		function show2(num)
		{
			if(num==1)
			{
				clearInterval(eid);
			}
			if(num==2)
			{
				eid=setInterval("fu1()",1000);
			}
		}