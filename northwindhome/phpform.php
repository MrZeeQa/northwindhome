<?php

$mail = $_POST['mail'];


$servername = "127.0.0.1";
$username = "root";
$db = "test";

$conn = new mysqli($servername, $username, $db);

if ($conn->connect_error){
	die("Connection failed: ". $conn->connect_error);
}

$sql = "insert into test(mail) values('$name','$age','$gender')";

if ($conn->query($sql) === TRUE) {
	echo "ADDED: ".$mail.";
} else {
	echo "Error: ".$sql."<br>".$conn->error;
}

$conn->close();

?>