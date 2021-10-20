from django.urls import path

from . import views     # it means - 'from all import views'

urlpatterns = [
    path('',views.index, name='index'),
    path('trans',views.transliterate, name='trans'),
    path('eng',views.transliterate_eng, name='eng')
]