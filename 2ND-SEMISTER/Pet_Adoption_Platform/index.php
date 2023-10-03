<?php
declare (strict_types=1);
error_reporting(E_ALL);
ini_set('display_errors', 1);
require_once "autoloader.php";
session_save_path('D:/.tmp/');
session_start();
$con=new models\conn();
$conn=$con->init();
foreach ($_ENV as $key => $value) {
    $$key=$value;
}
echo <<<HTML

    <link rel="stylesheet" href="public/assets/css/dist/style.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.4.2/css/all.min.css" integrity="sha512-z3gLpd7yknf1YoNbCzqRKc4qyor8gaKU1qmn+CShxbuBusANI9QpRohGBreCFkKxLhei6S9CQXFEbbKuqLg0DA==" crossorigin="anonymous" referrerpolicy="no-referrer" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.0/jquery.min.js"></script>
HTML;
$route=new controllers\routes($_SERVER['REQUEST_URI']);
$route->get();
