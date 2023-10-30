-- Update order to 'Delivered'
EXEC order_delivered @order_id = 1;

-- Update order to 'Cancelled'
EXEC order_cancelled @order_id = 2;

-- Clean up cancelled orders
EXEC clean_cancelled_order;
