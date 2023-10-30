<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="http://localhost/Pet_Adoption_Platform/public/assets/css/dist/style.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.7.0/jquery.min.js"></script>
    <title>404 Not Found</title>
    <style>
        main  > * {
            width: 100%;
        }
    </style>
</head>

<body class="dark:bg-[#2a2a2a] dark:text-white">
    <main class="flex flex-wrap w-full text-center items-center py-[10%] h-screen" role="main" aria-describedby="main">
            <section class="my-5" role="text">
                <p class="text-[10rem] font-extrabold">404</p>
                <p class="text-3xl">Page not found!</p>
            </section>
            <section class="h-1/4 my-5" role="link" aria-describedby="link">
                <button id="gotoHome" class="px-[45px] py-[18px] text-[20px] font-semibold hover:bg-blue-600 hover:text-white transition-all duration-[500ms]  border-blue-600 text-blue-600 text-base  border-2 rounded-full">
                    <p>Go to Home</p>
                </button>
            </section>
    </main>
    <script>
        $(document).ready(function() {
            $("#gotoHome").click(function() {
                window.location.href = "http://192.168.0.105/Pet_Adoption_Platform/";
            });
        });
    </script>
</body>

</html>