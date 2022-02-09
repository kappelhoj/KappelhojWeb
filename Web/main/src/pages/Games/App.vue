<template>
  <DefaultPage>
    <component :is="child_component"/>
  </DefaultPage>
</template>

<script>
import DefaultPage from '../../components/Structure/DefaultPage.vue'
import GameRoot from '../../components/Roots/GameRoot.vue'

export default{
  name: 'GamePage',
  components:{
    DefaultPage,
    GameRoot
  },
  data(){
    return {child_component: 'GameRoot'}
  }
}
</script>