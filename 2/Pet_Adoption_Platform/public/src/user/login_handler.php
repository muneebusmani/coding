<?php
$handler=new controllers\user\login($_POST['email'],$_POST['password']);
$handler->handler();