<template>
  <div class="page">
    <NavBar/>
    <slot></slot>
  </div>
</template>

<script>
import NavBar from '../../components/Navigation/NavBar.vue'

export default {
  name: 'DefaultPage',
    components: {
    NavBar
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>
