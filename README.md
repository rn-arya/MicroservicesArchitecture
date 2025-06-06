# 1. get product request using gateway
#curl --location 'https://localhost:5000/Products'

# 2. get product by id
curl --location --request GET 'https://localhost:5000/Products/3' \
--header 'Content-Type: text/plain' \
--data '{
"name":"Product C"
,"price":30
}'

# 3. Add product
curl --location 'https://localhost:5000/Products' \
--header 'Content-Type: application/json' \
--data '{
"name":"Product C"
,"price":30
}'

# 4. Create Order
curl --location 'https://localhost:5000/orders' \
--header 'Content-Type: application/json' \
--data '{
"productid":3
,"quantity":2
}'

# 5. Ger order
curl --location 'https://localhost:5000/orders'

# 6. Create shipping
curl --location 'https://localhost:5000/shipping' \
--header 'Content-Type: application/json' \
--data '{
"orderid":1
,"address":"Nirala Aspire"
}'

# 7. Get shipping
curl --location 'https://localhost:5000/shipping'
