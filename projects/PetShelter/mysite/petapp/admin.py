from django.contrib import admin
from .models import Pet
from .models import Contact

# Register your models here.
admin.site.register(Pet)
admin.site.register(Contact)
