<?php 
$KEY=$_GET["key"];
$pTokn=$_GET["pToken"];
exec('python3.5 main.py "'.$KEY.'&pToken='.$pTokn.'"');
readfile("export.fkt");
?>
