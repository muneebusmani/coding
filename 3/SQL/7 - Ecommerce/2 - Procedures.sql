/**
* This Procedure will Help in registering Customers
*/
    create procedure customerRegistration
        @name varchar(255),
        @email varchar(255),
        @phone varchar(255),
        @address varchar(255),
        @city varchar(255),
        @state varchar(255),
        @country varchar(255),
        @zip varchar(255)
    as
    begin
        insert into customers
            (name,email,phone,address,city,state,country,zipcode)
        values(@name, @email, @phone, @address, @city, @state, @country, @zip)
    end;
/**/





/**
* This Procedure will Help in adding Products 
*/
    /** 
    * adding products
    */
        create procedure productRegistration
            @name varchar(255),
            @description varchar(255),
            @price varchar(255),
            @category varchar(255)
        as
        BEGIN
            insert into products
                (name,description,price,category)
            values(@name, @description, @price, @category)
        end;
    /**/



    /** 
    * deleteing products
    */
        create procedure productDelete
        @id int
        AS
        BEGIN
            delete from products WHERE id = @id
        END;
    /**/


        /**
        *   These Procedures will be used to update different columns of products separately
        */

            create procedure productUpdateName
            @id int,
            @name varchar(255)
            AS
            BEGIN
                update products set name = @name where id=@id
            END;

                CREATE PROCEDURE productUpdateDescription
                @id int,
                @description varchar(255)
            AS
            BEGIN
                UPDATE products SET description = @description WHERE id = @id
            END;

            CREATE PROCEDURE productUpdatePrice
                @id int,
                @price varchar(255)
            AS
            BEGIN
                UPDATE products SET price = @price WHERE id = @id
            END;

            
            CREATE PROCEDURE productUpdateCategory
                @id int,
                @category varchar(255)
            AS
            BEGIN
                UPDATE products SET category = @category WHERE id = @id
            END;

            CREATE PROCEDURE productUnavailable
            @id int
            AS
            BEGIN
            UPDATE products SET [availability] = 'unavailable' WHERE id = @id
            END;

        /**/

/**/







/**
* This Procedure will Help in orders
*/
    create procedure orderCreation
        @customer_id int,
        @product_id int,
        @order_date date,
        @order_status varchar(255)
    as
    begin
        insert into orders
            (customer_id, product_id, order_date, order_status)
        values
            (@customer_id, @product_id, @order_date, @order_status)
    end;
/**/





/**
* This Procedure will Help in fetching current orders
*/
    CREATE PROCEDURE fetch_orders
    AS
    BEGIN

        SELECT
            orders.id                           AS order_id,
            orders.order_date                   AS order_date,
            orders.order_status                 AS order_status,
            customers.name                      AS customer_name,
            customers.email                     AS customer_email,
            customers.phone                     AS customer_phone,
            customers.address                   AS customer_address,
            customers.city                      AS customer_city,
            customers.state                     AS customer_state,
            customers.country                   AS customer_country,
            customers.zipcode                   AS customer_zipcode,
            products.name                       AS product_name,
            products.description                AS product_description,
            products.price                      AS product_price,
            products.category                   AS product_category
        FROM orders 
        INNER JOIN customers ON orders.customer_id = customers.id
        INNER JOIN products ON orders.product_id = products.id

    END;
/**/





/**
* These Procedures will Help in updating orders
*/
    CREATE PROCEDURE order_delievered
    @order_id int
    AS
    BEGIN

        UPDATE orders SET order_status = 'Delievered' WHERE id = @order_id
    
    END;

    CREATE PROCEDURE order_cancelled
    @order_id int
    AS
    BEGIN

        UPDATE orders SET order_status = 'Cancelled' WHERE id = @order_id
    
    END;

    CREATE PROCEDURE clean_cancelled_order
    AS
    BEGIN
        DELETE FROM orders WHERE order_status = 'Cancelled'
    END;

/**/

