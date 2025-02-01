from django import forms
from .models import Pet
from .models import Contact


class PetForm(forms.ModelForm):
    class Meta:
        model = Pet
        fields = ['name', 'animal_type', 'difficulty', 'pet_desc', 'pet_image']


class InterestForm(forms.ModelForm):
    class Meta:
        model = Contact
        fields = ['name', 'pet_name', 'contact_email', 'description']
