<?php


$nome= $_GET ["nome"];
$nota1= $_GET ["n1"];
$nota2= $_GET ["n2"];
$nota3= $_GET ["n3"];
$media= ($nota1+$nota2+$nota3)/3;
$re= (7-$media);

echo "A MEDIDA ENTRE A $nota1 + $nota2 + $nota3 E $media<br> ";


$situacao = ($media<7)? "<h3>REPROVADO</h3><br> para ser aprovado e preciso $re": "<h3>APROVADO</h3>";

echo "$nome $situação";






?>