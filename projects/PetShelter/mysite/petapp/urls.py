from . import views
from django.urls import path

urlpatterns = [
    path('Home/', views.Home, name="Home"),
    path('Pets/', views.Pets, name="Pets"),
    path('Contact/', views.Contact, name="Contact"),
    path('<int:pet_id>', views.detail, name="detail"),
    path('add/', views.create_pet_profile, name="create_pet_profile"),
    path('update/<int:id>', views.update_pet, name="update_pet"),
    path('delete/<int:id>', views.delete_pet, name="delete_pet"),
    path('interest/', views.interest_form, name="interest_form"),
]
