<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <!-- Include jQuery library -->
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
</head>

<body>
    <div class="w-screen flex h-full p-[5%]">
        <form method="POST" action="login_handler" class="flex flex-col justify-center w-[40%] h-full px-[5%] bg-blue-300">
            <div class="form-group">
                <input type="email" id="email" placeholder="Email" name="email" class="form-control px-8">
            </div>
            <div class="form-group">
                <input type="password" id="password" placeholder="Password" name="password" class="form-control px-8 inline-flex">
            </div>
            <div class="form-group">
                <input class="text-white px-5 py-2 hover:bg-blue-600 bg-blue-900 rounded-full transition-colors duration-300 w-full" type="submit" value="submit" name="submit">
            </div>
        </form>
        <img class="w-[60%]" src="https://picsum.photos/800/450" alt="sample image">
    </div>
    <script>
        $(document).ready(function() {
            $('form').submit(function(event) {
                event.preventDefault(); // Prevents the form from being submitted
                const formData = $(this).serialize();
                $.ajax({
                    type: 'POST', // or 'GET' depending on your server setup
                    url: 'http://192.168.0.105/Pet_Adoption_Platform/login_handler', // Replace with your server endpoint
                    data: formData,
                    success: function(response) {
                        // Display the response in the result div
                        $('#result').html(response);
                    },
                    error: function(xhr, status, error) {
                        console.error(error); // Handle errors if necessary
                    }
                });
            });
        });
    </script>
</body>

</html>
