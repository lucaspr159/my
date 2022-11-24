<?php
//contar quantas vezes repete um elemento no array
$array = array("Lucas","Mateus","João","Lucas","Gustavo","Lucas");
$arrayRepetido = array();

for($i = 0; $i < count($array);$i++){//percorre o array
    $valorAtual = $array[$i];//exibe todos elementos array
    if(!isset($arrayRepetido[$valorAtual])){
        $arrayRepetido[$valorAtual] = 0;
    }else{
        $arrayRepetido[$valorAtual]++;
    }
}
foreach($arrayRepetido as $key => $value){
    echo $key;
    echo " ";
    echo $value;
    echo "<hr>";
}

?>