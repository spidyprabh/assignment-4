class User < ApplicationRecord
  validates(
    :email,
    presence: true,
    length: {
      maximum: 255
    },
    format: { with: /\A([^@\s]+)@((?:[-a-z0-9]+\.)+[a-z]{2,})\z/i}
  )

  validates(
    :name,
    presence: true,
    length: {
      maximum: 255
    }
  )

  validates(
    :name,
    presence: true,
    length: {
      maximum: 255
    }
  )

  validates(
    :phone,
    presence: true,
    length: {
      maximum: 255
    },
    format: { with: /((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}/ }
  )

  validates(
    :address,
    presence: true
  )

  validates(
    :city,
    presence: true
  )

  validates(
    :vehicle_make,
    presence: true
  )

  validates(
    :vehicle_model,
    presence: true
  )

  validates(
    :vehicle_year,
    presence: true,
    numericality: true
  )

  def get_url
    "https://www.jdpower.com/Cars/#{self.vehicle_year}/#{self.vehicle_make}/#{self.vehicle_model}"
  end
end
