class CreateUsers < ActiveRecord::Migration[5.1]
  def change
    create_table :users do |t|
      t.string :email
      t.string :name
      t.string :address
      t.string :phone
      t.string :city
      t.string :vehicle_make
      t.string :vehicle_model
      t.string :vehicle_year

      t.timestamps
    end
  end
end
