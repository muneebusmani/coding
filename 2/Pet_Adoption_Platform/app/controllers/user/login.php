<?php
namespace controllers\user;
use models\conn;
class login{
    private $email;
    private $password;
    function __construct($email,$password) {
        $this->email = $email;
        $this->password = $password;
    }
    function handler(){
        $con = new models\conn();
        $conn = $con->init();
        
        $query = "[login] :username ,:password";
        $params = array(':username' => 'your_username', ':password' => 'your_password');
        $stmt = $conn->prepare($query);
        if ($stmt->execute($params)) {
            echo "yes";
        } else {
            echo "no";
        }
    }
}