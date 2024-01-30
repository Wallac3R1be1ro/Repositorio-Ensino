<?php
    
$Recibo=$_GET["recibo"];
$Matricula=$_GET["matricula"];
$Nome=$_GET["nome"];
$Recebido=$_GET["recebido"];
$Referente...=$_GET["referente"];


   //comando de bloco-------------------------------
   try
   {
       $comando=$conexao->prepare("SELECT * FROM alunos");

   if($comando->execute())
   {
       while ($linha=$comando->fetch(PDO::FETCH_OBJ))
       {
           echo 'Recibo: '.$linha->recibo.'<br>';
           echo 'Matricula: '.$linha->matricula.'<br>';
           echo 'Nome: '.$linha->nome.'<br>';
           echo 'Recebido: '.$linha->recebido.'<br>';
           echo 'Referente: '.$linha->referente.'<br><br>';
           
       }
   }
   else
   {
       echo "<script>alert('Recebemos o valor R$!')</script>";
       echo ('<meta http-equiv="refresh"content=0;"exer16.html">');
   }
   }
   catch (PDOException $erro)
   {
       echo "Erro:".$erro->getMessage();
   }

