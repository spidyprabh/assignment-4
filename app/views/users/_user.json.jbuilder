json.extract! user, :id, :email, :name, :address, :phone, :city, :vehicle_make, :vehicle_model, :vehicle_year, :created_at, :updated_at
json.url user_url(user, format: :json)
