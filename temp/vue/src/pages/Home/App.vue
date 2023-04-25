<template>
  <DefaultPage>
    <component :is="child_component"/>
  </DefaultPage>
</template>

<script>
import DefaultPage from '../../components/Structure/DefaultPage.vue'
import HomeRoot from '../../components/Roots/HomeRoot.vue'

export default{
  name: 'DevPage',
  components:{
    DefaultPage,
    HomeRoot
  },
  data(){
    return {child_component: 'HomeRoot'}
  }
}
</script>

