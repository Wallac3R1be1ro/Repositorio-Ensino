
		for(var i = 20; i > 0; i--){
			
			console.log(i);
			
			if(i === 5) {
				break;
			}
		}
		
		console.log("Deu break"); // Com break podemos encerrar umas instrução;
		
		var x = 10;
		
		while(x < 100){
		
		x += 10;
		
		if(x === 60 || x === 90){
			console.log("CONTINUE");
			continue;
		}
		
		console.log("Testando continue " + x); // Com o continue podemos pular uma instrução;
		
		}
