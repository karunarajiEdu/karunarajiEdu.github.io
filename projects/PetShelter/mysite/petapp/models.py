from django.db import models

# Create your models here.


class Pet(models.Model):
    def __str__(self):
        return self.name

    name = models.CharField(max_length=200)
    animal_type = models.CharField(max_length=200)
    difficulty = models.CharField(max_length=200)
    pet_desc = models.CharField(max_length=500)
    pet_image = models.CharField(max_length=500, default="https://animalmicrochips.co.uk/images/default_no_animal.jpg")


class Contact(models.Model):
    def __str__(self):
        return self.attr_name

    name = models.CharField(max_length=200)
    pet_name = models.CharField(max_length=200)
    contact_email = models.CharField(max_length=200)
    description = models.CharField(max_length=1000)
